﻿//////////////////////////////////////////////////
/// File: UIManager2.cs
/// Author: Sam Baker
/// Date created: 27/02/20
/// Last edit: 02/03/20
/// Description: A new UI manger to handle elements on the canvas.
/// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager2 : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private TextMeshProUGUI m_moneyText = null;
    [SerializeField] private Color m_moneyColor = Color.black;
    [SerializeField] private TextMeshProUGUI m_ingotsText = null;
    [SerializeField] private Color m_ingotsColor = Color.black;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_moneyText.color = m_moneyColor;
        m_ingotsText.color = m_ingotsColor;
    }

    private void Update()
    {
        m_moneyText.text = PlayersBank.Instance.GetMoney().ToString("n0");
        m_ingotsText.text = PlayersBank.Instance.GetIngots().ToString("n0");
    }
}