//////////////////////////////////////////////////
// File: SaveItemManager.cs
// Author: Zack Raeburn
// Date Created: 27/02/20
// Description: Manages save items in the main menu UI
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveItemManager : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private List<SaveItem> m_saveItems = null;
    [SerializeField] private List<GameObject> m_deleteButtons = null;


    //////////////////////////////////////////////////
    //// Functions

    private void Awake()
    {
        // DELETES ALL SAVES
        //SaveGameManager.DeleteCharacter(0);
        //SaveGameManager.DeleteCharacter(1);
        //SaveGameManager.DeleteCharacter(2);
        //SaveGameManager.DeleteCharacter(3);
        //SaveGameManager.SaveHeader();

        if (m_saveItems == null)
            enabled = false;

        if (m_saveItems.Count != 4)
        {
            Debug.LogError("4 save items are required to fill in save info");
            return;
        }

        AssignSaveSlotInfo();
    }

    /// <summary>
    /// Display save info in the main menu UI
    /// </summary>
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
            m_saveItems[i].m_characterFile = save;
            m_saveItems[i].SetName(save.m_name);
            m_saveItems[i].SetBottomText("Level: " + save.m_level + "   $" + save.m_money);
            
        }
    }

    /// <summary>
    /// When a save slot is clicked either create a new save by going to character creation or load the file
    /// </summary>
    /// <param name="a_slot"></param>
    public void StartGame(int a_slot)
    {
        if (SaveGameManager.IsSaveSlotOccupied(a_slot) == true)
        {
            SaveGameManager.SetMainCharFile(m_saveItems[a_slot].m_characterFile);
            // Load scenes
            SceneLoadManager.Instance.LoadScenesLoadingScreen(3);
        }
        else
        {
            // Save new file to be edited later
            SaveGameManager.CreateCharacter(a_slot);

            // Go to character creation
            SceneLoadManager.Instance.LoadCharacterCreation();
        }
    }

    public void deleteSave0()
    {
        SaveGameManager.DeleteCharacter(0);
        SaveGameManager.SaveHeader();
    }    
    public void deleteSave1()
    {
        SaveGameManager.DeleteCharacter(1);
        SaveGameManager.SaveHeader();
    }    
    public void deleteSave2()
    {
        SaveGameManager.DeleteCharacter(2);
        SaveGameManager.SaveHeader();
    }    
    public void deleteSave3()
    {
        SaveGameManager.DeleteCharacter(3);
        SaveGameManager.SaveHeader();
    }
}
