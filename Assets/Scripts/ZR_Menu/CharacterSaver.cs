//////////////////////////////////////////////////
// File: CharacterSaver.cs
// Author: Zack Raeburn
// Date Created: 28/02/20
// Description: Saving the character file from the character creation scene
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSaver : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private TMP_InputField m_name = null;

    //////////////////////////////////////////////////
    //// Functions

    /// <summary>
    /// Pack all character settings into the save file and load the game
    /// </summary>
    public void FinishCharacterCreation()
    {
        SaveSlot save = SaveGameManager.GetMainCharFile();
        save.m_name = m_name.text;
        save.m_money = 10f;
        SaveGameManager.SaveCharacter(save);

        // Load default scenes
    }
}
