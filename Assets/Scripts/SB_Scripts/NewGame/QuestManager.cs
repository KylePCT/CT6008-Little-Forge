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

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        FindQuestGiver();
        UpdateQuest();
    }

    private void FindQuestGiver()
    {
        var tempQuestGivers = GameObject.FindObjectsOfType<QuestGiver>();
        foreach (var QuestGivers in tempQuestGivers)
        {
            if(QuestGivers.GetActive())
            {
                m_currentQuestGiver = QuestGivers;
            }
        }
    }

    private void UpdateQuest()
    {
        m_questText.text = m_currentQuestGiver.GetQuestDetails(0) + "\n" + m_currentQuestGiver.GetQuestDetails(1) + "\n" + m_currentQuestGiver.GetQuestReward();
    }
}
