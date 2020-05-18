//////////////////////////////////////////////////
// File: SimpleFurniture.cs
// Author: Sam Baker
// Date Created: 06/05/20
// Last Edit:
// Description: Quick script to demonstrate the furniture for the trailer
// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleFurniture : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private bool m_inRange = false;
    [SerializeField] private GameObject m_interactionText = null;
    private bool m_showUI = false;
    private FurniturePanel m_furniturePanel = null;
    private GameObject m_go = null;

    [SerializeField] private GameObject m_player = null;
    [SerializeField] private GameObject m_playerOrientation = null;
    [SerializeField] private GameObject m_uiTheFurniture = null;

    private GameObject m_outline = null;

    private InputSystem m_inputSystem = null;


    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();

    private void Start()
    {
        m_outline = transform.GetChild(0).gameObject;
        m_uiTheFurniture.SetActive(false);
        AssignChecks();
    }

    private void AssignChecks()
    {
        if (GameObject.Find("NewCanvas"))
        {
            m_furniturePanel = GameObject.Find("NewCanvas").GetComponent<FurniturePanel>();
        }
        else
        {
            Debug.LogError("ERROR: SimpleFurniture.cs could not find NewCanvas game object!");
        }

        //if (GameObject.Find("InteractText"))
        //{
        //    m_interactionText = GameObject.Find("InteractText");
        //}
        //else
        //{
        //    Debug.LogError("ERROR: SimpleFurniture.cs could not find InteractText game object!");
        //}
    }

    private void Update()
    {
        InteractionKey();
    }

    private void ShouldFurnitureMenuBeOpen()
    {
        if (m_showUI)
        {
            m_uiTheFurniture.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            m_player.GetComponent<PlayerControls>().OnDisable();
            m_playerOrientation.GetComponent<PlayerOrientation>().OnDisable();
            m_player.GetComponent<FiringWeapon>().SetWeaponActive(false);
            m_player.GetComponent<PlayerZoom>().enabled = false;
        }
        else
        {
            m_uiTheFurniture.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            m_player.GetComponent<PlayerControls>().OnEnable();
            m_playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
            m_player.GetComponent<FiringWeapon>().SetWeaponActive(true);
            m_player.GetComponent<PlayerZoom>().enabled = true;
        }
    }

    private void InteractionKey()
    {
        if (m_inputSystem.Player.Interact.triggered)
        {
            if (m_inRange)
            {
                //Open Furniture Menu
                m_showUI = !m_showUI;
                ShouldFurnitureMenuBeOpen();
            }
        }
    }
    //Detect range of player
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_inRange = true;
            m_furniturePanel.WhoOpenedPanel(this);
            m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to place furniture";
            m_interactionText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_inRange = false;
            m_furniturePanel.WhoOpenedPanel(null);
            m_interactionText.SetActive(false);
        }
    }

    public void PlaceFurniture(GameObject a_go)
    {
        if (m_go != null)
        {
            Destroy(m_go);
            m_go = null;
        }
        m_go = Instantiate(a_go, transform.position, Quaternion.identity);
        m_go.transform.parent = gameObject.transform;
        m_outline.SetActive(false);
    }
}
