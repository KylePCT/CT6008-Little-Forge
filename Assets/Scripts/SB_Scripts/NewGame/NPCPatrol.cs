//////////////////////////////////////////////////
/// File: NPCPatrol.cs
/// Author: Sam Baker
/// Date created: 27/02/20
/// Last edit: 27/02/20
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCPatrol : MonoBehaviour
{
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > Space triggers interaction.")]
    [Space(-10)]
    [Header(" > Interaction is closed with any input.")]
    [Space(-10)]
    [Header(" > Patrols to a random position in the yellow sphere.")]
    [Space(-10)]
    [Header("NPC PATROL")]
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private string[] m_dialogue = new string[6];
    private NPCStates m_currentState = NPCStates.NPC_FINDLOCATION;
    private NavMeshAgent m_navMeshAgent = null;
    private Vector3 m_destination;
    private Vector3 m_randPosition;
    private GameObject m_nameObject = null;
    private GameObject m_cam = null;
    private float m_waitTimer = 2.0f;
    [Header("NPC Parameters")]
    [SerializeField] [Tooltip("Yellow circle indication")] private float m_wanderRadius = 15.0f;
    [SerializeField] private float m_speed = 3.0f;
    [SerializeField] private string m_name = "m_NPCName";
    [SerializeField] private Color m_nameColour = Color.black;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_cam = Camera.main.gameObject;
        m_nameObject = transform.GetChild(0).gameObject;
        m_nameObject.GetComponentInChildren<TextMesh>().text = m_name;
        m_nameObject.GetComponentInChildren<TextMesh>().color = m_nameColour;
        m_currentState = NPCStates.NPC_FINDLOCATION;
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        if (m_navMeshAgent == null)
        {
            Debug.LogWarning("Warning: Unable to locate NPC's NavMeshAgent component");
        }
        m_navMeshAgent.speed = m_speed;
    }

    private void Update()
    {
        //////////// *TEMP* //////////// DELETE LATER
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_currentState = NPCStates.NPC_INTERACT;
        }
        //////////// *TEMP* //////////// DELETE LATER
        m_nameObject.transform.LookAt(m_cam.transform.position);
        switch (m_currentState)
        {
            case NPCStates.NPC_FINDLOCATION:
                FindLocation();
                break;
            case NPCStates.NPC_WALKTOLOCATION:
                WalkToLocation();
                break;
            case NPCStates.NPC_INTERACT:
                InteractedWith();
                break;
            case NPCStates.NPC_WAITFORPLAYER:
                WaitForPlayerInput();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Function used to send the AI to a position on the navigatable mesh.
    /// </summary>
    private void SetDestination()
    {
        if (m_destination != null)
        {
            m_navMeshAgent.SetDestination(m_destination);
        }
    }
    /// <summary>
    /// Function used to get a random point on the navmesh, gets a random point within a sphere.
    /// </summary>
    /// <param name="a_origin">Center of the sphere.</param>
    /// <param name="a_dist">Radius of the sphere.</param>
    /// <param name="a_layermask"></param>
    /// <returns>Return a Vector3.</returns>
    public static Vector3 RandomNavSphere(Vector3 a_origin, float a_dist, int a_layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * a_dist;
        randDirection += a_origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, a_dist, a_layermask);

        return navHit.position;
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, m_wanderRadius);
    }

    //////////////////////////////////////////////////
    //// Functions - States
    private void FindLocation()
    {
        m_randPosition = RandomNavSphere(transform.position, m_wanderRadius, -1);
        m_destination = m_randPosition;
        SetDestination();
        m_currentState = NPCStates.NPC_WALKTOLOCATION;
    }
    private void WalkToLocation()
    {
        if (Vector3.Distance(transform.position, m_destination) < 1.5f)
        {
            //m_currentState = NPCStates.NPC_INTERACT;
            m_currentState = NPCStates.NPC_FINDLOCATION;
        }
    }
    private void InteractedWith()
    {
        Debug.Log("NPC Said: " + m_dialogue[Random.Range(0, m_dialogue.Length)]);
        m_waitTimer = 2.0f;
        m_currentState = NPCStates.NPC_WAITFORPLAYER;
    }
    private void WaitForPlayerInput()
    {
        //TO DO
        //  Look at player
        //  Dialogue pops up on screen
        m_waitTimer -= Time.deltaTime;
        if(m_waitTimer <= 0)
        {
            if (Input.anyKey)
            {
                m_currentState = NPCStates.NPC_FINDLOCATION;
            }
        }   
    }

    private enum NPCStates
    {
        NPC_FINDLOCATION,
        NPC_WALKTOLOCATION,
        NPC_INTERACT,
        NPC_WAITFORPLAYER
    };
}
