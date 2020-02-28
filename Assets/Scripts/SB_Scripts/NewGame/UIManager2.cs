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
    [SerializeField] private Color m_moneyColor = Color.black;
    [SerializeField] private Text m_forgeText = null;
    [SerializeField] private Color m_forgeColor = Color.black;
    private ForgeRebuild m_forge;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_forge = GameObject.Find("- FORGELAND ASSETS/Forge").GetComponent<ForgeRebuild>();
        m_moneyText.color = m_moneyColor;
        m_forgeText.color = m_forgeColor;
    }

    private void Update()
    {
        m_moneyText.text = PlayersBank.Instance.GetMoney().ToString();
        m_forgeText.text = m_forge.GetForgeLevel().ToString();
    }
}
