//////////////////////////////////////////////////
/// File: UIManager2.cs
/// Author: Sam Baker
/// Date created: 27/02/20
/// Last edit: 28/02/20
/// Description: A new UI manger to handle elements on the canvas.
/// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Text m_moneyText = null;
    [SerializeField] private Color m_textColor = Color.black;

    //////////////////////////////////////////////////
    //// Functions
    private void Start() => m_moneyText.color = m_textColor;

    private void Update() => m_moneyText.text = PlayersBank.Instance.GetMoney().ToString();
}
