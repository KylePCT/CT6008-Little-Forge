using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KT_Quit : MonoBehaviour
{
    // Start is called before the first frame update
    public void gameIsKill()
    {
        Application.Quit();
        Debug.Log("Game is kill.");
    }
}
