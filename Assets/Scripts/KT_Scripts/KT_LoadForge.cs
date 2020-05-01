//////////////////////////////////////////////////
// File: KT_LoadForge.cs
// Author: Kyle Tugwell
// Date created: 10/03/2020
// Description: Load the forge scene.
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
      
      
public class KT_LoadForge : MonoBehaviour {
      
void OnTriggerEnter(Collider p)
    {
        //If the player enters the collision box
              if (p.tag == "Player") 
              {
                  //Load the forge scene
                  SceneManager.LoadScene(4);
              }
          }
      }