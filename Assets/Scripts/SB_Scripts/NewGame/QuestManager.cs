//////////////////////////////////////////////////
/// File: QuestManager.cs
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
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Text m_questText = null;
    [SerializeField] private QuestGiver m_currentQuestGiver = null;
    private static QuestManager m_instance;
    public static QuestManager Instance { get { return m_instance; } }

    //////////////////////////////////////////////////
    //// Functions
    private void Awake()
    {
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;
        }
    }

    private void Update()
    {
        UpdateQuestText();
    }

    private void UpdateQuestText()
    {
        if (m_currentQuestGiver != null)
        {
            if(m_currentQuestGiver.GetCompleted())
            {
                m_questText.text = m_currentQuestGiver.GetQuestDetails(0) + "\nReturn quest for reward.\n" + m_currentQuestGiver.GetQuestReward();
                return;
            }
            m_questText.text = m_currentQuestGiver.GetQuestDetails(0) + "\n" + m_currentQuestGiver.GetQuestDetails(1) + "\n" + m_currentQuestGiver.GetQuestReward();
        }
        else
        {
            m_questText.text = "No current quest.";
        }
    }

    public void UpdateQuestGiver(QuestGiver a_questGiver)
    {
        m_currentQuestGiver = a_questGiver;
    }
}
