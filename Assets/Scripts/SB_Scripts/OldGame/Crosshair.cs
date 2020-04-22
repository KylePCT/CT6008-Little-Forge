﻿//////////////////////////////////////////////////
/// File: Crosshair.cs
/// Author: Sam Baker
/// Date created: 02/02/20
/// Last edit: 22/02/20
/// Description: For the use of the onscreen UI for the crosshair. Using raycasts to
///             detect what the player is aimed at.
/// Comments:
//////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    public Camera cam;
    public Image crosshair;

    public GameObject enemyTarget;

    public GameObject playerRotation;

    private Controls controls = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start() {
        crosshair.color = Color.black;
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void Update() {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100.0f)) {
            if (hit.transform.tag == "Boss") {
                EnemyOnCrossHair();
                enemyTarget = hit.transform.gameObject;
            }
            else if (hit.transform.tag == "Enemy") {
                enemyTarget = hit.transform.gameObject;
                EnemyOnCrossHair();
            } else if (hit.transform.tag == "Pillar") {
                EnemyOnCrossHair();
                enemyTarget = hit.transform.gameObject;
            }
            else if (hit.transform.tag == "Follower") {
                FriendlyOnCrossHair();
            } else {
                ReturnCrossHair();
            }
        } else {
            ReturnCrossHair();
        }
    }

    private void FriendlyOnCrossHair() {
        crosshair.color = Color.green;
    }

    private void EnemyOnCrossHair() {
        crosshair.color = Color.red;
        playerRotation.GetComponent<PlayerRotation>().rotSensitivity = playerRotation.GetComponent<PlayerRotation>().origSensitivity / 2.0f;
    }

    private void ReturnCrossHair() {
        crosshair.color = Color.black;
        playerRotation.GetComponent<PlayerRotation>().rotSensitivity = playerRotation.GetComponent<PlayerRotation>().origSensitivity;
    }
}
