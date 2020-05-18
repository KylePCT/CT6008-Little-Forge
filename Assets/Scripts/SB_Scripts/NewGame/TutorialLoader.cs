//////////////////////////////////////////////////
// File: TutorialLoader.cs
// Author: Sam Baker
// Date Created: 17/05/20
// Last Edit: 
// Description: Script used to start the tutorial cinematic
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLoader : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private bool m_tutorialCalled = false;

    //////////////////////////////////////////////////
    //// Functions
    private void OnTriggerEnter(Collider col)
    {
        if (!m_tutorialCalled)
        {
            if (col.gameObject.tag == "Player")
            {
                m_tutorialCalled = true;
                LoadTutCinematic();
            }
        }
    }

    private void LoadTutCinematic()
    {
        Debug.Log("***THIS IS WHERE THE TUTORIAL CINEMATIC SHOULD TRIGGER*** ***DOUBLE CLICK TO GO TO CODE***");
    }
}
