//////////////////////////////////////////////////
/// File: SaveItemManager.cs
/// Author: Zack Raeburn
/// Date Created: 27/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveItemManager : MonoBehaviour
{

    [SerializeField] private List<SaveItem> m_saveItems = null;
    private void Awake()
    {
        if (m_saveItems == null)
            enabled = false;

        if (m_saveItems.Count != 4)
        {
            Debug.LogError("4 save items are required to fill in save info");
            return;
        }

        AssignSaveSlotInfo();
    }

    private void AssignSaveSlotInfo()
    {
        for(int i = 0; i < m_saveItems.Count; ++i)
        {
            if (!SaveGameManager.IsSaveSlotOccupied(i))
            {
                m_saveItems[i].SetEmpty();
                continue;
            }

            SaveSlot save = SaveGameManager.LoadCharacter(i);
            m_saveItems[i].SetName(save.m_name);
            m_saveItems[i].SetMoney(save.m_money);
            
        }
    }
}
