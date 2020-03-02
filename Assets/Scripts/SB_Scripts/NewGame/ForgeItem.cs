//////////////////////////////////////////////////
/// File: ForgeItem.cs
/// Author: Sam Baker
/// Date created: 02/03/20
/// Last edit: 02/03/20
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ForgeItem : MonoBehaviour
{
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header("     correct position on the forge.")]
    [Space(-10)]
    [Header(" > The gameobject should be placed in its")]
    [Space(-10)]
    [Header(" > Set the base price of the item.")]
    [Space(-10)]
    [Header("Forge Item")]
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private float m_baseCost = 0.0f;
    private float m_previousCost = 0.0f;
    private float m_currentCost = 0.0f;
    private int m_itemLevel = 0;
    private TextMesh m_itemText = null;
    private InputSystem m_inputSystem = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    private void OnEnable() => m_inputSystem.Player.Enable();
    private void OnDisable() => m_inputSystem.Player.Disable();
    private void Start()
    {
        m_itemText = transform.GetChild(0).gameObject.GetComponent<TextMesh>();
        if(m_itemLevel > 0)
        {
            m_currentCost = m_baseCost;
        }
        else
        {
            m_currentCost = m_baseCost;
            m_previousCost = m_baseCost;
        }
        UpdateItemText();
    }

    private void Update()
    {
        UpdateItemText();
    }

    private void BuyUpgrade()
    {
        if (m_itemLevel == 9)
        {
            return;
        }
        if(PlayersBank.Instance.GetMoney() > m_currentCost)
        {
            PlayersBank.Instance.TakeAwayMoney(m_currentCost);
            m_itemLevel++;
            CalculateNewCost();
        }
        else
        {
            Debug.Log("Log: Not Enough To Purchase Upgrade!!!");
        }
    }

    private void UpdateItemText()
    {
        if(m_itemLevel == 10)
        {
            m_itemText.text = gameObject.name + "\nLevel: " + m_itemLevel + "\nUpgrade Cost:\n" + "MAX LEVEL";
            return;
        }
        m_itemText.text = gameObject.name + "\nLevel: " + m_itemLevel + "\nUpgrade Cost:\n" + m_currentCost.ToString("n0");
    }

    private void CalculateNewCost()
    {
        m_previousCost = m_currentCost;
        m_currentCost = Mathf.Ceil(m_previousCost * (m_itemLevel + 1));
        UpdateItemText();
    }

    public int GetLevel() => m_itemLevel;
    public float GetUpgradeCost() => m_currentCost;
    public void ButtonBuyUpgrade() => BuyUpgrade();
}
