//////////////////////////////////////////////////
// File: ShopTrigger.cs
// Author: Sam Baker
// Date Created: 24/05/20
// Last Edit: 
// Description: Script used for triggering the shop
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.InputSystem;

public class ShopTrigger : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private GameObject m_interactionText = null;
    private bool m_inRange = false;
    private bool m_shouldMenuBeOpen = false;
    [SerializeField] private GameObject m_shopUI = null;
    private GameObject m_player = null;
    private GameObject m_playerOrientation = null;
    private InputSystem m_inputSystem = null;


    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();
    private void Start()
    {
        m_interactionText = GetInteractText.Instance.m_interactionText;
        m_shopUI.SetActive(false);
        m_player = GameObject.Find("Player");
        m_playerOrientation = GameObject.Find("PlayerOrientation");
    }

    private void Update()
    {
        InteractionKey();
        CheckIfMenuShouldBeOpen();
    }

    private void CheckIfMenuShouldBeOpen()
    {
        if(m_shouldMenuBeOpen)
        {
            //MENU OPEN DISABLE INPUT
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            m_shopUI.SetActive(true);
            m_interactionText.SetActive(false);
            m_player.GetComponent<PlayerInput>().enabled = false;
            m_player.GetComponent<PlayerControls>().OnDisable();
            m_playerOrientation.GetComponent<PlayerOrientation>().OnDisable();
            m_player.GetComponent<FiringWeapon>().SetWeaponActive(false);
            m_player.GetComponent<PlayerZoom>().enabled = false;
        }
        else
        {
            m_shopUI.SetActive(false);
        }
    }

    private void InteractionKey()
    {
        if (m_inputSystem.Player.Interact.triggered)
        {
            if (m_inRange)
            {
                m_shouldMenuBeOpen = !m_shouldMenuBeOpen;
                if (!m_shouldMenuBeOpen)
                {
                    //MENU CLOSED ENABLE INPUT
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    m_interactionText.SetActive(true);
                    m_player.GetComponent<PlayerInput>().enabled = true;
                    m_player.GetComponent<PlayerControls>().OnEnable();
                    m_playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
                    m_player.GetComponent<FiringWeapon>().SetWeaponActive(true);
                    m_player.GetComponent<PlayerZoom>().enabled = true;
                }
            }
        }
        //Second key used to close the shop
        if(m_inputSystem.Player.ESCkey.triggered)
        {
            if (m_inRange)
            {
                m_shouldMenuBeOpen = false;
                Debug.Log("TRigger");
                //MENU CLOSED ENABLE INPUT
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to open Shop";
                m_interactionText.SetActive(true);
                m_player.GetComponent<PlayerInput>().enabled = true;
                m_player.GetComponent<PlayerControls>().OnEnable();
                m_playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
                m_player.GetComponent<FiringWeapon>().SetWeaponActive(true);
                m_player.GetComponent<PlayerZoom>().enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to open Shop";
            m_interactionText.SetActive(true);
            m_inRange = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.SetActive(false);
            m_inRange = false;
            m_shouldMenuBeOpen = false;
            m_shopUI.SetActive(false);
        }
    }
}
