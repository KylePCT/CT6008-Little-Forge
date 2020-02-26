//////////////////////////////////////////////////
/// File: Button.cs
/// Author: Zack Raeburn
/// Date Created: 19/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(MaskableGraphic))]
public class Button : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerExitHandler
{
    [SerializeField] private float m_fadeSpeed = 1f;

    [SerializeField] private UnityEvent m_onMouseDown = null;
    [SerializeField] private UnityEvent m_onMouseEnter = null;
    [SerializeField] private UnityEvent m_onMouseExit = null;

    private MaskableGraphic m_graphic = null;

    private void Awake()
    {
        m_graphic = GetComponent<MaskableGraphic>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (m_onMouseDown != null)
            m_onMouseDown.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (m_onMouseEnter != null)
            m_onMouseEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (m_onMouseExit != null)
            m_onMouseExit.Invoke();
    }

    private void Fade(float a_alpha)
    {
        m_graphic.raycastTarget = false;
        StopAllCoroutines();
        StartCoroutine(FadeIE(m_fadeSpeed, a_alpha));
    }

    private IEnumerator FadeIE(float a_speed, float a_alpha)
    {
        Color c = m_graphic.color;
        float startColour = c.a;
        float startTime = Time.time;

        while(c.a != a_alpha)
        {
            c.a = Mathf.MoveTowards(c.a, a_alpha, (Time.time - startTime) * a_speed);
            m_graphic.color = c;

            yield return null;
        }

        m_graphic.raycastTarget = true;
    }
}
