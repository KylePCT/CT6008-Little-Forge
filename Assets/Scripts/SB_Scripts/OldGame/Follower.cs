﻿//////////////////////////////////////////////////
/// File: Follower.cs
/// Author: Sam Baker
/// Date created: 02/02/20
/// Last edit: 18/02/20
/// Description: Simple script used to control the follower, a quick state machine.
/// Comments:
//////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Follower : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Transform destination;
    NavMeshAgent navMeshAgent;

    public string followerName;
    public GameObject nameText;
    public GameObject nameTextHolder;
    public GameObject uiActionText;

    [SerializeField] private GameObject player;

    private AI_FOLLOWER_STATES currentState;

    public int health;
    public float speed;
    public float damage;

    private bool isAcquired;

    public GameObject enemyTarget;

    private Controls controls = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        navMeshAgent.speed = speed;
        if (navMeshAgent == null) {
            Debug.Log("Error: NavMeshAgent is not attatched to this AI");
        }
        isAcquired = false;
        nameText.GetComponent<TextMesh>().text = followerName;
        currentState = AI_FOLLOWER_STATES.FOLLOWER_IDLE;
    }

    private void Update() {
        nameTextHolder.transform.LookAt(Camera.main.transform.position);
        if (isAcquired) {
            if (controls.Player.SendFollowerAttack.triggered) {
                if (GameObject.FindGameObjectWithTag("CrossHair").GetComponent<Crosshair>().enemyTarget != null) {
                    enemyTarget = GameObject.FindGameObjectWithTag("CrossHair").GetComponent<Crosshair>().enemyTarget;
                    if (enemyTarget != null) {
                        navMeshAgent.speed = speed;
                        currentState = AI_FOLLOWER_STATES.FOLLOWER_SENT_TO_ATTACK;
                    } else {
                        Debug.Log("No Target!");
                    }
                }
            }
            if (controls.Player.SendFollowerAway.triggered) {
                isAcquired = false;
                currentState = AI_FOLLOWER_STATES.FOLLOWER_IDLE;
            }
        }
        switch (currentState) {
            case AI_FOLLOWER_STATES.FOLLOWER_IDLE:

                break;
            case AI_FOLLOWER_STATES.FOLLOWER_FOLLOWING:
                if (Vector3.Distance(player.transform.position, transform.position) <= 4.0f) {
                    navMeshAgent.speed = 0.0f;
                } else {
                    navMeshAgent.speed = speed;
                    destination = player.transform;
                    SetDestination();
                }
                break;
            case AI_FOLLOWER_STATES.FOLLOWER_SENT_TO_ATTACK:
                if (enemyTarget == null) {
                    currentState = AI_FOLLOWER_STATES.FOLLOWER_FOLLOWING;
                    break;
                }
                destination = enemyTarget.transform;
                SetDestination();
                break;
            default:
                break;
        }
    }

    public void OnTriggerStay(Collider col) {
        if (col.tag == "Player") {
            if (isAcquired == false) {  //swapped brackets here
                uiActionText.SetActive(true);
                if (controls.Player.Interaction.triggered) {    //with here - Alice (18/2 10:27)
                    destination = player.transform;
                    SetDestination();
                    currentState = AI_FOLLOWER_STATES.FOLLOWER_FOLLOWING;
                    uiActionText.SetActive(false);
                    isAcquired = true;
                }
            }
        }
        if (col.tag == "Enemy") {
            //col.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }

        
    }

    public void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Boss")
        {
            col.gameObject.GetComponent<Health>().TakeBulletDamage(damage, col.transform.position);
        }
        if (col.gameObject.tag == "Pillar")
        {
            col.gameObject.GetComponentInParent<Health>().TakeBulletDamage(damage, col.transform.position);
            Debug.Log(col.gameObject.transform.parent.name);
        }
    }

    public void OnTriggerExit(Collider col) {
        if (col.tag == "Player") {
            uiActionText.SetActive(false);
        }
    }

    private void SetDestination() {
        if (destination != null) {
            Vector3 targerVector = destination.transform.position;
            navMeshAgent.SetDestination(targerVector);
        }
    }

    public enum AI_FOLLOWER_STATES {
        FOLLOWER_IDLE,
        FOLLOWER_FOLLOWING,
        FOLLOWER_SENT_TO_ATTACK
    }
}
