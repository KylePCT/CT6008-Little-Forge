//////////////////////////////////////////////////
// File: SplashScreen.cs
// Author: Sam Baker
// Date Created: 04/05/20
// Description: Simple script used to call a function at the end of an animation
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public void LoadGame()
    {
        //Hide this UI
        gameObject.SetActive(false);
    }
}
