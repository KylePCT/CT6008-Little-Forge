//////////////////////////////////////////////////
/// File: BasicEnemyAI.cs
/// Author: Sam Baker
/// Date created: 01/03/20
/// Last edit: 01/03/20
/// Description: Script that can be placed on any object that can be destroyed.
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemyAI : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private ENEMYStates m_currentState = ENEMYStates.ENE_FINDLOCATION;
    private NavMeshAgent m_navMeshAgent = null;
    private Vector3 m_destination;
    private Vector3 m_randPosition;
    private GameObject m_player = null;
    [Header("Enemy Parameters")]
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header("     range that the enemy can spot the player.")]
    [Space(-15)]
    [Header(" > Change Sphere Radius ^^ to change the")]
    [Space(-10)]
    [Header("Basic Enemy AI")]
    [SerializeField] [Tooltip("Yellow circle indication")] private float m_wanderRadius = 15.0f;
    [SerializeField] private float m_speed = 3.0f;
    [SerializeField] private float m_damagePerSecond = 15.0f;
    private float m_waitTimer = 0.0f;
    private float m_attackTimer = 0.0f;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_player = GameObject.Find("Sam'sTempCharacterController/Player");
        m_currentState = ENEMYStates.ENE_FINDLOCATION;
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        if (m_navMeshAgent == null)
        {
            Debug.LogWarning("Warning: Unable to locate NPC's NavMeshAgent component");
        }
        m_navMeshAgent.speed = m_speed;
    }

    private void Update()
    {
        switch(m_currentState)
        {
            case ENEMYStates.ENE_FINDLOCATION:
                FindLocation();
                break;
            case ENEMYStates.ENE_WALKTOLOCATION:
                WalkToLocation();
                break;
            case ENEMYStates.ENE_HUNTPLAYER:
                HuntPlayer();
                break;
            case ENEMYStates.ENE_LOOSEPLAYER:
                LoosePlayer();
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
        Vector3 randDirection = UnityEngine.Random.insideUnitSphere * a_dist;
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
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, GetComponent<SphereCollider>().radius*1.6f);
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_currentState = ENEMYStates.ENE_HUNTPLAYER;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_waitTimer = 4;
            m_currentState = ENEMYStates.ENE_LOOSEPLAYER;
        }
    }

    //////////////////////////////////////////////////
    //// Functions - States
    private void FindLocation()
    {
        m_randPosition = RandomNavSphere(transform.position, m_wanderRadius, -1);
        m_destination = m_randPosition;
        SetDestination();
        m_currentState = ENEMYStates.ENE_WALKTOLOCATION;
    }
    private void WalkToLocation()
    {
        if (Vector3.Distance(transform.position, m_destination) < 1.5f)
        {
            m_currentState = ENEMYStates.ENE_FINDLOCATION;
        }
        else if (m_navMeshAgent.velocity == Vector3.zero)
        {
            m_currentState = ENEMYStates.ENE_FINDLOCATION;
        }
    }

    private void HuntPlayer()
    {
        if (Vector3.Distance(transform.position, m_player.transform.position) < 1.5f)
        {
            //Attack player
            m_attackTimer -= Time.deltaTime;
            if(m_attackTimer <= 0)
            {
                m_player.GetComponent<ObjectHealth>().TakeDamage(m_damagePerSecond/2);
                m_attackTimer = 0.5f;
            }
        }
        else
        {
            m_attackTimer = 0.5f;
            m_destination = m_player.transform.position;
            SetDestination();
        }
    }
    private void LoosePlayer()
    {
        m_waitTimer -= Time.deltaTime;
        if (m_waitTimer <= 0)
        {
            m_currentState = ENEMYStates.ENE_FINDLOCATION;
        }
    }

    private enum ENEMYStates
    {
        ENE_FINDLOCATION,
        ENE_WALKTOLOCATION,
        ENE_HUNTPLAYER,
        ENE_LOOSEPLAYER
    };
}
