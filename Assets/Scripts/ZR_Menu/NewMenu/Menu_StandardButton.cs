using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Menu_StandardButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private UnityEvent m_OnClick;
    public UnityEvent OnClick
    {
        get { return m_OnClick; }
    }
    [SerializeField] private UnityEvent m_OnEnter;
    [SerializeField] private UnityEvent m_OnExit;

    public void OnPointerClick(PointerEventData eventData)
    {
        m_OnClick.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        m_OnEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_OnExit.Invoke();
    }
}
