﻿//////////////////////////////////////////////////
// File: KT_LoadForge.cs
// Author: Kyle Tugwell
// Date created: 10/03/2020
// Last edit: 01/05/20 -Sam
// Description: Load the forge scene.
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KT_LoadForge : MonoBehaviour
{
    [SerializeField] private GameObject m_interactText = null;
    void OnTriggerEnter(Collider p)
    {
        //If the player enters the collision box
        if (p.tag == "Player")
        {
            //Edited by sam
            //Disable the player controls
            p.GetComponent<PlayerControls>().enabled = false;
            //TP Player to the forge
            p.transform.position = GameObject.Find("ForgeSpawnPoint").transform.position;
            m_interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to open Forge";
        }
    }
    void OnTriggerExit(Collider p)
    {
        //If the player enters the collision box
        if (p.tag == "Player")
        {
            p.GetComponent<PlayerControls>().enabled = true;
        }
    }
}