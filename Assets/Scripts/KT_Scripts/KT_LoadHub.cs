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
                  //Load the hub scene
                  SceneManager.LoadScene(3);
              }
          }
      }