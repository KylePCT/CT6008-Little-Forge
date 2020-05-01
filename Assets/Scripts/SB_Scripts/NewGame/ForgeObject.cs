//////////////////////////////////////////////////
/// File: ForgeObject.cs
/// Author: Sam Baker
/// Date created: 02/03/20
/// Last edit: 02/03/20
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class ForgeObject : MonoBehaviour
{
    [Header("Forge Object")]
    //////////////////////////////////////////////////
    //// Variables
    private bool m_inRange = false;
    private bool m_shouldMenuBeOpen = false;
    private GameObject m_interactionText = null;

    public GameObject forgeUI;
    private InputSystem m_inputSystem = null;


    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_interactionText = GameObject.Find("InteractText");
    }

    private void Update()
    {
        InteractionKey();
    }

    private void InteractionKey()
    {
        if (m_inputSystem.Player.Interact.triggered)
        {
            if (m_inRange)
            {
                m_shouldMenuBeOpen = !m_shouldMenuBeOpen;
            }
        }
    }

    public void InteractKey(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_inRange)
            {
                m_shouldMenuBeOpen = !m_shouldMenuBeOpen;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.SetActive(true);
            m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to open Forge";
            m_inRange = true;
            forgeUI.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.SetActive(true);
            m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to open Forge";
            m_inRange = true;
            forgeUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.SetActive(false);
            m_inRange = false;
            m_shouldMenuBeOpen = false;
            forgeUI.SetActive(false);
        }
    }

    public bool ShouldMenuBeOpen()
    {
        return m_shouldMenuBeOpen;
    }
    public void MenuClosed()
    {
        m_shouldMenuBeOpen = false;
    }
}
