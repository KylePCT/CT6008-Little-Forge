//////////////////////////////////////////////////
/// File: GameManager.cs
/// Author: Zack Raeburn
/// Date Created: 27/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Awake()
    {
        SaveGameManager.LoadHeader();
    }

}
