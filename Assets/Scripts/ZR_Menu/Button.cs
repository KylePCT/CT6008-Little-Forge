//////////////////////////////////////////////////
// File: Button.cs
// Author: Zack Raeburn
// Date Created: 19/02/20
// Description: A simple UI button
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
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private UnityEvent m_onMouseDown = null;
    [SerializeField] private UnityEvent m_onMouseEnter = null;
    [SerializeField] private UnityEvent m_onMouseExit = null;

    private MaskableGraphic m_graphic = null;

    //////////////////////////////////////////////////
    //// Functions

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
}
