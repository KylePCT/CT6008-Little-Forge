//////////////////////////////////////////////////
// File: ShopRowScript.cs
// Author: Sam Baker
// Date Created: 24/05/20
// Last Edit: 
// Description: Script used to set up this row for the shop
// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopRowScript : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Item m_item = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        UpdateRowDetails();
    }

    private void UpdateRowDetails()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = m_item.m_itemName.ToUpper();
        transform.GetChild(1).transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "$" + m_item.m_buyPrice.ToString("n0");
        transform.GetChild(2).transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "$" + m_item.m_sellPrice.ToString("n0");
    }

    public void BuyItem()
    {
        if(PlayersBank.Instance.TakeAwayMoney(m_item.m_buyPrice))
        {
            KT_AudioManager.instance.playSound("UIHigh");

            //SPECIAL ITEM (does not have any inventory vaule)
            if (m_item.name == "item_ingot")
            {
                //Player had enough funds
                PlayersBank.Instance.AddIngots(1);
                return;
            }

            InventoryManager.instance.AddItem(m_item, 1);

            if (m_item.name == "item_SeedLettuvia" || m_item.name == "item_SeedAleeks")
            {
                QuestCheck("SB_GetSeeds");
            }

            if (m_item.name == "item_ingot")
            {
                PlayersBank.Instance.AddIngots(1);
                PlayersBank.Instance.TakeAwayMoney(1000);
            }
        }
        else
        {
            KT_AudioManager.instance.playSound("Decline");
        }
    }

    public void SellItem()
    {
        //SPECIAL ITEM (does not have any inventory vaule)
        if (m_item.name == "item_ingot")
        {
            if (PlayersBank.Instance.TakeAwayIngots(1))
            {
                //Player has enough ingots
                PlayersBank.Instance.AddMoney(m_item.m_sellPrice);
                KT_AudioManager.instance.playSound("UIHigh");
            }
            else
            {
                //No ingots
                KT_AudioManager.instance.playSound("Decline");
            }
            return;
        }

        if (InventoryManager.instance.RemoveItem(m_item))
        {
            PlayersBank.Instance.AddMoney(m_item.m_sellPrice);

            KT_AudioManager.instance.playSound("UIHigh");

            if (m_item.name == "item_slime")
            {
                QuestCheck("SB_SellSlime");
            }

        }

        else
        {
            KT_AudioManager.instance.playSound("Decline");
        }
    }
    private void QuestCheck(string a_questName)
    {
        if (QuestManager.Instance.CurrentQuestGiver() == null)
        {
            return;
        }
        else if (QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().name == a_questName)
        {
            QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().SetCompleted(true);
        }
    }
}
