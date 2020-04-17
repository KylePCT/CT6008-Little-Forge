using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu_VerticalButtonController : MonoBehaviour
{
    [SerializeField] private float m_buttonTextSizeSmall = 50f;
    [SerializeField] private float m_buttonTextSizeLarge = 70f;
    [SerializeField] private float m_buttonTextAnimationSpeed = 5f;

    [SerializeField] private List<TextMeshProUGUI> m_buttons;
    [SerializeField] private IEnumerator[] m_buttonIEnumerators;
    [SerializeField] private int m_selectedButton = 0;

    private InputMap m_inputControls;
    private IEnumerator m_currentIE = null;

    private void Awake()
    {
        Init();

        //SetSelectedButton(m_selectedButton);
    }

    private void Init()
    {
        m_inputControls = new InputMap();

        m_buttonIEnumerators = new IEnumerator[m_buttons.Count];
    }

    private void SelectDirection(UnityEngine.InputSystem.InputAction.CallbackContext a_context)
    {
        if (m_buttons == null || m_buttons.Count == 0)
            return;

        Vector2 movement = a_context.ReadValue<Vector2>();
        
        if (movement.y == -1f)
            m_selectedButton = (m_selectedButton + 1) % m_buttons.Count;
        else if (movement.y == 1f)
            m_selectedButton = (m_selectedButton + m_buttons.Count - 1) % m_buttons.Count;

        SetSelectedButton(m_selectedButton);
    }

    private void SelectAccept(UnityEngine.InputSystem.InputAction.CallbackContext a_context)
    {
        if (m_buttons == null || m_buttons.Count == 0)
            return;

        m_buttons[m_selectedButton].GetComponent<Menu_StandardButton>().OnPointerClick(null);
    }
    
    private void SelectDecline(UnityEngine.InputSystem.InputAction.CallbackContext a_context)
    {
        
    }

    public void SetSelectedButton(int a_buttonIndex)
    {
        if (a_buttonIndex < 0 || a_buttonIndex > m_buttons.Count - 1)
            return;

        m_selectedButton = a_buttonIndex;
        for (int i = 0; i < m_buttons.Count; ++i)
        {
            if (m_buttonIEnumerators[i] != null)
                StopCoroutine(m_buttonIEnumerators[i]);

            if (i == m_selectedButton)
                m_buttonIEnumerators[i] = TweenButtonSize(m_buttons[i], true);
            else
                m_buttonIEnumerators[i] = TweenButtonSize(m_buttons[i], false);

            StartCoroutine(m_buttonIEnumerators[i]);
        }
    }

    private IEnumerator TweenButtonSize(TextMeshProUGUI a_button, bool a_expanding)
    {
        float current = a_button.fontSize;
        float timeOffset;
        float fontTarget;

        if (a_expanding)
        {
            timeOffset = (current - m_buttonTextSizeSmall) / (m_buttonTextSizeLarge - m_buttonTextSizeSmall);
            fontTarget = m_buttonTextSizeLarge;
        }
        else
        {
            timeOffset = 1f - ((current - m_buttonTextSizeSmall) / (m_buttonTextSizeLarge - m_buttonTextSizeSmall));
            fontTarget = m_buttonTextSizeSmall;
        }

        float startTime = Time.time;
        while(a_button.fontSize != fontTarget)
        {
            a_button.fontSize = Mathf.Lerp(current, fontTarget, ((Time.time - startTime) + timeOffset) * m_buttonTextAnimationSpeed);
            yield return null;
        }

        yield return null;
    }

    public void ExitMenuMain()
    {
        float start = 7.5f;
        float end = 50f;

        if (m_currentIE != null)
            return;

        m_currentIE = AnimateMenuIE(start, end);
        StartCoroutine(m_currentIE);
    }

    public void EnterMenuMain()
    {
        float start = 50f;
        float end = 7.5f;

        if (m_currentIE != null)
            return;

        m_currentIE = AnimateMenuIE(start, end);
        StartCoroutine(m_currentIE);
    }

    private IEnumerator AnimateMenuIE(float startAngle, float endAngle)
    {
        Quaternion rotStart = Quaternion.Euler(startAngle, 0f, 0f);
        Quaternion rotEnd = Quaternion.Euler(endAngle, 0f, 0f);

        float startTime = Time.time;
        while (Camera.main.transform.rotation != rotEnd)
        {
            float dampTime = Mathf.SmoothStep(0f, 1f, Time.time - startTime);
            Camera.main.transform.rotation = Quaternion.Lerp(rotStart, rotEnd, dampTime);
            yield return null;
        }

        m_currentIE = null;
    }

    private void OnEnable()
    {
        m_inputControls.Menu.Move.started += SelectDirection;
        m_inputControls.Menu.Accept.performed += SelectAccept;
        m_inputControls.Menu.Decline.performed += SelectDecline;

        m_inputControls.Enable();
    }

    private void OnDisable()
    {
        m_inputControls.Menu.Move.started -= SelectDirection;
        m_inputControls.Menu.Accept.performed -= SelectAccept;
        m_inputControls.Menu.Decline.performed -= SelectDecline;

        m_inputControls.Disable();
    }
}
