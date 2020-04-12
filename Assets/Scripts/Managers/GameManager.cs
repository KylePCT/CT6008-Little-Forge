//////////////////////////////////////////////////
// File: GameManager.cs
// Author: Zack Raeburn
// Date Created: 27/02/20
// Description: A central manager for important managerial things
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables



    //////////////////////////////////////////////////
    //// Functions

    private void Awake()
    {
        SaveGameManager.LoadHeader();
    }

    private void Update()
    {
        GameSaver();
    }

    private void GameSaver()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach(GameObjectSaverLoader o in GameObjectSaverLoader.CurrentWorldObjects)
            {
                o.SaveObjectData();
            }
            SaveGameManager.SaveCharacter(SaveGameManager.GetMainCharFile());
        }
    }

}
