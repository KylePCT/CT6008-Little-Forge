//////////////////////////////////////////////////
/// File: ForgeManager.cs
/// Author: Sam Baker
/// Date created: 02/03/20
/// Last edit: 02/03/20
/// Description: A script to manage everything for the Forge, all the UI is assigned here
///             and object sorting.
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
    private GameObject m_uiProductionRate = null;
    private GameObject[] m_uiItemID = new GameObject[7];

    private GameObject m_theForge = null;
    private GameObject[] m_theForgeItems = new GameObject[7];

    private float m_ignotsTickTimer = 0;

    private float m_productionRate = 0;

    [SerializeField] private GameObject m_player;
    [SerializeField] private GameObject m_playerOrientation;
    [SerializeField] private GameObject m_weapon;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_ignotsTickTimer = 2.0f;
        m_uiTheForge = gameObject.transform.Find("TheForgeUI").gameObject;
        m_uiItemHolder = gameObject.transform.Find("TheForgeUI/panel/ScrollRect/Viewport/Upgrades").gameObject;
        m_uiProductionRate = gameObject.transform.Find("TheForgeUI/panel/TotalProduction").gameObject;
        m_theForge = GameObject.Find("---- FORGE");
        StartErrorChecks();
        for (int i = 0; i < m_uiItemID.Length; i++)
        {
            m_uiItemID[i] = m_uiItemHolder.transform.GetChild(i).gameObject;
            m_theForgeItems[i] = m_theForge.transform.GetChild(i + 1).gameObject;

            Button btn = m_uiItemID[i].transform.GetChild(3).GetComponent<Button>();
            btn.onClick.AddListener(m_theForgeItems[i].GetComponent<ForgeItem>().ButtonBuyUpgrade);

        }
        UpdateForgeUI();
        m_uiTheForge.SetActive(false);
    }

    private void Update()
    {
        UpdateForgeUI();
        
        UpdateIngots();
    }

    private void UpdateIngots()
    {
        m_ignotsTickTimer -= Time.deltaTime;
        if (m_ignotsTickTimer <= 0)
        {
            //(m_productionRate/60)/30) - this gets the production rate of every two seconds
            PlayersBank.Instance.AddIngots(((m_productionRate / 60) / 30));
            m_ignotsTickTimer = 2.0f;
        }
    }

    public void CheckIfMenuShouldBeOpen()
    {
        if (m_theForge.transform.GetChild(0).gameObject.GetComponent<ForgeObject>().ShouldMenuBeOpen())
        {
            m_uiTheForge.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            m_player.GetComponent<PlayerControls>().OnDisable();
            m_playerOrientation.GetComponent<PlayerOrientation>().OnDisable();
            m_weapon.GetComponent<FiringWeapon>().SetWeaponActive(false);
            m_player.GetComponent<PlayerZoom>().enabled = false;
        }
        else
        {
            m_uiTheForge.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            m_player.GetComponent<PlayerControls>().OnEnable();
            m_playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
            m_weapon.GetComponent<FiringWeapon>().SetWeaponActive(true);
            m_player.GetComponent<PlayerZoom>().enabled = true;
        }
    }

    private void UpdateForgeUI()
    {
        for (int i = 0; i < m_uiItemID.Length; i++)
        {
            m_uiItemID[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = m_theForgeItems[i].name + " - Level: " +
            m_theForgeItems[i].GetComponent<ForgeItem>().GetLevel();
            m_uiItemID[i].transform.GetChild(2).GetComponent<Text>().text = "COST: " + m_theForgeItems[i].GetComponent<ForgeItem>().GetUpgradeCost().ToString("n0");

            if(m_theForgeItems[i].GetComponent<ForgeItem>().GetLevel() == 9)
            {
                m_uiItemID[i].transform.GetChild(2).GetComponent<Text>().text = "MAX LEVEL";
            }
        }
        CalculateProductionRate();
        m_uiProductionRate.GetComponent<TextMeshProUGUI>().text = "Production Rate: " + m_productionRate.ToString("n0") + " p/h"; 
    }

    private void StartErrorChecks()
    {
        if (m_uiItemHolder == null)
        {
            Debug.LogError("ERROR: 'UpgradeHolder or Upgrades' is not in the 'New Canvas'.");
        }
        if (m_theForge == null)
        {
            Debug.LogError("ERROR: '---- FORGE' is not in the Scene.");
        }
    }

    private int CalculateTotalLevel()
    {
        int m_totalLevel = 0;
        int m_fallbacktemp = 0;
        for (int i = 0; i < m_uiItemID.Length; i++)
        {
            if (m_theForgeItems[i].GetComponent<ForgeItem>().GetLevel() == 0)
            {
                m_fallbacktemp++;
            }
            else
            {
                m_totalLevel += m_theForgeItems[i].GetComponent<ForgeItem>().GetLevel();
            }

            if(m_fallbacktemp == 7)
            {
                return 0;
            }
        }
        return m_totalLevel;
    }

    private void CalculateProductionRate()
    {
        float m_temp = CalculateTotalLevel();
        m_productionRate = ((m_temp * m_temp) / 5);
    }
}
