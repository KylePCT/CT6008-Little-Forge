//////////////////////////////////////////////////
// File: Menu_MainButton.cs
// Author: Zack Raeburn
// Date Created: 12/04/20
// Description: Navigates the main menu
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Menu_MainButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    //////////////////////////////////////////////////
    //// Variables
    
    [SerializeField] private float m_animationSpeed = 1f;

    [SerializeField] private float m_fontSizeSmall = 50f;
    [SerializeField] private float m_fontSizeLarge = 100f;

    [SerializeField] private UnityEvent m_OnClick = null;

    private TextMeshProUGUI m_TMP = null;
    private IEnumerator m_currentIE = null;
    private static List<Menu_MainButton> m_buttonInstances = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        if (m_buttonInstances == null)
            m_buttonInstances = new List<Menu_MainButton>();

        m_buttonInstances.Add(this);

        m_TMP = GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (m_currentIE != null)
            StopCoroutine(m_currentIE);

        foreach(Menu_MainButton button in m_buttonInstances)
        {
            if (button == this)
                continue;

            if (button.m_currentIE != null)
                button.StopCoroutine(button.m_currentIE);

            button.m_currentIE = button.ChangeFontSize(m_fontSizeLarge, m_fontSizeSmall);
            button.StartCoroutine(button.m_currentIE);
        }

        m_currentIE = ChangeFontSize(m_fontSizeSmall, m_fontSizeLarge);
        StartCoroutine(m_currentIE);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (m_OnClick != null)
            m_OnClick.Invoke();
    }

    private IEnumerator ChangeFontSize(float a_startFontSize, float a_targetFontSize)
    {
        float m_currentFontSize = m_TMP.fontSize;
        float startTime = Time.time;
        float offset = (m_currentFontSize - a_startFontSize) / (a_targetFontSize - a_startFontSize);

        while (m_TMP.fontSize != a_targetFontSize)
        {
            m_TMP.fontSize = Mathf.Lerp(a_startFontSize, a_targetFontSize, ((Time.time - startTime) + offset) * m_animationSpeed);
            yield return null;
        }
    }
}
