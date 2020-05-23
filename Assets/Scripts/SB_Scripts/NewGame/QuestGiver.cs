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
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuestGiver : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Quest[] m_questList = new Quest[0];
    private Quest m_quest = null;
    
    public bool m_questActive = false;
    [SerializeField] private bool m_inRange = false;
    [SerializeField] private GameObject m_interactionText = null;
    private int m_questsCompleted = 0;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_interactionText = GameObject.Find("InteractText");
    }
    private void Update()
    {
        if (m_questActive)
        {
            m_quest.Update();
        }
        if(m_quest == null)
        {
            CheckForNextQuest();
        }
    }

    private void CheckForNextQuest()
    {
        if (m_questsCompleted < m_questList.Length)
        {
            m_quest = m_questList[m_questsCompleted];
            m_quest.Assign();
        }
        else
        {
            m_quest = null;
        }
    }

    private void GetReward()
    {
        m_questsCompleted++;
        PlayersBank.Instance.AddMoney(m_quest.GetMoneyReward());
        PlayersBank.Instance.AddIngots(m_quest.GetIngotReward());
        KT_LevelSystem.Instance.gainXP(50);
        m_quest = null;
        m_questActive = false;
    }

    public bool GetActive() => m_questActive;

    public bool GetCompleted() => m_quest.GetCompleted();
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
        if(m_quest.GetMoneyReward() != 0 && m_quest.GetIngotReward() != 0)
        {
            return "Reward: $" + m_quest.GetMoneyReward().ToString() + " & " + m_quest.GetIngotReward().ToString() + " Ingots";
        }
        else if(m_quest.GetMoneyReward() != 0)
        {
            return "Reward: $" + m_quest.GetMoneyReward().ToString();
        }
        else if (m_quest.GetIngotReward() != 0)
        {
            return "Reward: " + m_quest.GetIngotReward().ToString() + " Ingots";
        }
        return null;
    }

    public void InteractKey(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_inRange)
            {
                if (!m_questActive)
                {
                    m_questActive = true;
                    m_interactionText.SetActive(false);

                    QuestManager.Instance.UpdateQuestGiver(this);

                    return;
                }
                else
                {
                    if (m_quest.GetCompleted())
                    {
                        m_interactionText.SetActive(false);
                        m_inRange = false;

                        QuestManager.Instance.UpdateQuestGiver(null);

                        GetReward();
                    }
                }
            }
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (m_quest != null)
        {
            if (col.gameObject.tag == "Player")
            {
                m_inRange = true;
                if (!m_questActive)
                {
                    m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to Accept '" + m_quest.GetData(0) + "' Quest!";
                    m_interactionText.SetActive(true);

                }
                else
                {
                    if(m_quest.GetCompleted())
                    {
                        m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to Claim Reward!";
                        m_interactionText.SetActive(true);
                    }
                }
            }
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_interactionText.SetActive(false);
            m_inRange = false;
        }
    }

    public Quest GetCurrentQuest()
    {
        if (m_questActive)
        {
            return m_quest;
        }
        else
        {
            return null;
        }
    }
}
