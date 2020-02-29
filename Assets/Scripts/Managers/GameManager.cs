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

}
