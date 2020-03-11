//////////////////////////////////////////////////
/// File: QuestGiver.cs
/// Author: Sam Baker
/// Date created: 11/03/20
/// Last edit: 11/03/20
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Quest m_quest = null;
    
    [SerializeField] private float m_moneyReward = 0;
    [SerializeField] private float m_ingotReward = 0;

    [SerializeField] private bool m_active = false;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_quest.Assign();
    }
    private void Update()
    {
        m_quest.Update();
        CheckCompletion();
    }

    private void CheckCompletion()
    {
        if (m_quest.GetCompleted())
        {
            Debug.Log("Quest Complete");
            PlayersBank.Instance.AddMoney(m_moneyReward);
            PlayersBank.Instance.AddIngots(m_ingotReward);
            m_quest = null;
        }
    }

    public bool GetActive() => m_active;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a_value">0 - Name, 1 - Description, 2 - Amount</param>
    /// <returns></returns>
    public string GetQuestDetails(int a_value)
    {
        return m_quest.GetData(a_value);
    }

    public string GetQuestReward()
    {
        if(m_moneyReward != 0 && m_ingotReward != 0)
        {
            return "Reward: \n$" + m_moneyReward.ToString() + "\n" + m_ingotReward.ToString() + " Ingots";
        }
        else if(m_moneyReward != 0)
        {
            return "Reward: \n$" + m_moneyReward.ToString();
        }
        else if (m_ingotReward != 0)
        {
            return "Reward: \n" + m_ingotReward.ToString() + " Ingots";
        }
        return null;
    }
}
