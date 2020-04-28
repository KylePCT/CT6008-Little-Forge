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
            //Reset player position
            EssentialSceneFlow.instance.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<PlayerControls>().SetStartingPos();
            //Load the hub scene
            SceneManager.LoadScene("Hub");
        }
    }
}