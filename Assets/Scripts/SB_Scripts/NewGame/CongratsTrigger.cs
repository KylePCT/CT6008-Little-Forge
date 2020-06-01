//////////////////////////////////////////////////
// File: CongratsTrigger.cs
// Author: Sam Baker
// Date Created: 31/05/20
// Last Edit:
// Description: Script used to display congrats UI
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratsTrigger : MonoBehaviour
{
    //////////////////////////////////////////////////s
    //// Variables
    [SerializeField] private float m_displayTime = 3.0f;
    private float m_timer = 0.0f;


    //////////////////////////////////////////////////
    //// Functions
    private void OnEnable()
    {
        //Maybe a fade in animation here
        m_timer = m_displayTime;
    }

    private void Update()
    {
        if (m_timer <= 0)
        {
            //Maybe a fade out animation here, triggering this DisableTrigger()
            //  at the end of the animation
            gameObject.SetActive(false);
        }
        else
        {
            m_timer -= Time.deltaTime;
        }
    }

    //public void DisableTrigger()
    //{
    //    gameObject.SetActive(false);
    //}
}
