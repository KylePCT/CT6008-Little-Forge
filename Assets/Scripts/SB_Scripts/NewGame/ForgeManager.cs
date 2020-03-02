//////////////////////////////////////////////////
/// File: ForgeManager.cs
/// Author: Sam Baker
/// Date created: 02/03/20
/// Last edit: 02/03/20
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ForgeManager : MonoBehaviour
{

    [Header("Forge Manager")]
    //////////////////////////////////////////////////
    //// Variables
    //UI
    private GameObject m_uiTheForge = null;
    private GameObject m_uiItemHolder = null;
    private GameObject[] m_uiItemID = new GameObject[7];

    private GameObject m_theForge = null;
    private GameObject[] m_theForgeItems = new GameObject[7];
    private InputSystem m_inputSystem = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    private void OnEnable() => m_inputSystem.Player.Enable();
    private void OnDisable() => m_inputSystem.Player.Disable();
    private void Start()
    {
        m_uiTheForge = gameObject.transform.Find("TheForgeUI").gameObject;
        m_uiItemHolder = gameObject.transform.Find("TheForgeUI/panel/UpgradeHolder").gameObject;
        m_theForge = GameObject.Find("---- FORGE");
        StartErrorChecks();
        for (int i = 0; i < m_uiItemID.Length; i++)
        {
            m_uiItemID[i] = m_uiItemHolder.transform.GetChild(i).gameObject;
            m_theForgeItems[i] = m_theForge.transform.GetChild(i + 1).gameObject;
            Debug.Log(m_uiItemID[i].name + "   " + m_theForgeItems[i].name);

            Button btn = m_uiItemID[i].transform.GetChild(3).GetComponent<Button>();
            btn.onClick.AddListener(m_theForgeItems[i].GetComponent<ForgeItem>().ButtonBuyUpgrade);

        }
        UpdateForgeUI();
        m_uiTheForge.SetActive(false);
    }

    private void Update()
    {
        UpdateForgeUI();
        CheckIfMenuShouldBeOpen();
        
    }

    private void CheckIfMenuShouldBeOpen()
    {
        if (m_theForge.transform.GetChild(0).gameObject.GetComponent<ForgeObject>().ShouldMenuBeOpen())
        {
            m_uiTheForge.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            m_uiTheForge.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void UpdateForgeUI()
    {
        for (int i = 0; i < m_uiItemID.Length; i++)
        {
            m_uiItemID[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = m_theForgeItems[i].name + " - Level: " +
                m_theForgeItems[i].GetComponent<ForgeItem>().GetLevel();
            m_uiItemID[i].transform.GetChild(2).GetComponent<Text>().text = "Cost: " + m_theForgeItems[i].GetComponent<ForgeItem>().GetUpgradeCost().ToString("n0");
        }
    }

    private void StartErrorChecks()
    {
        if (m_uiItemHolder == null)
        {
            Debug.LogError("ERROR: 'UpgradeHolder' is not in the 'New Canvas'.");
        }
        if (m_theForge == null)
        {
            Debug.LogError("ERROR: '---- FORGE' is not in the Scene.");
        }
    }
}
