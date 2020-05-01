//////////////////////////////////////////////////
// File: KT_LoadHub.cs
// Author: Kyle Tugwell
// Date created: 10/03/2020
// Description: Load the hub scene.
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
      
      
public class KT_LoadHub : MonoBehaviour {

    void OnTriggerEnter(Collider p)
    {
        //If the player enters the collision box
        if (p.tag == "Player")
        {
            //Disable the player controls
            p.GetComponent<PlayerControls>().enabled = false;

            //TP Player to the forge
            p.transform.LookAt(GameObject.Find("HubSpawnPoint").transform.position);
            p.transform.position = GameObject.Find("HubSpawnPoint").transform.position;
            GameObject.Find("PlayerOrientation").gameObject.transform.rotation = Quaternion.Euler(8, -90, 0);
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