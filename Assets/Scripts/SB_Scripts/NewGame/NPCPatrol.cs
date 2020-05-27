//////////////////////////////////////////////////
/// File: NPCPatrol.cs
/// Author: Sam Baker
/// Date created: 27/02/20
/// Last edit: 27/05/20
/// Description: Script used to control everything on the NPC
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

//Enum for male or female voice
public enum Voice
{
    Male,
    Female
}

[RequireComponent(typeof(NavMeshAgent))]
public class NPCPatrol : MonoBehaviour
{
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > 'F' triggers interaction.")]
    [Space(-10)]
    [Header(" > Interaction is closed with any input.")]
    [Space(-10)]
    [Header(" > Patrols to a random position in the yellow sphere.")]
    [Space(-10)]
    [Header("NPC PATROL")]
    //////////////////////////////////////////////////
    //// Variables
    public string[] m_dialogue;
    [Tooltip("Set to no move for stationary NPC else find location.")]
    [SerializeField] private NPCStates m_currentState = NPCStates.NPC_FINDLOCATION;
    private NavMeshAgent m_navMeshAgent = null;
    private Vector3 m_destination;
    private Vector3 m_randPosition;
    private GameObject m_nameObject = null;
    private GameObject m_cam = null;
    private GameObject m_player = null;
    private float m_waitTimer = 2.0f;
    private GameObject m_interactionText = null;
    [Header("NPC Parameters")]
    [SerializeField] [Tooltip("Yellow circle indication")] private float m_wanderRadius = 15.0f;
    [SerializeField] private float m_speed = 3.0f;
    [SerializeField] private string m_name = "m_NPCName";
    [SerializeField] private Color m_nameColour = Color.black;
    private bool m_interacted = false;
    private bool m_inRangeOfPlayer = false;
    public GameObject m_continueTextUI;
    private Animator m_charAnimator = null;
    private bool m_isTalking = false;
    private int m_index;
    private InputSystem m_inputSystem = null;

    [SerializeField] Voice charVoice;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    private void OnEnable() => m_inputSystem.Player.Enable();
    private void OnDisable() => m_inputSystem.Player.Disable();
    private void Start()
    {
        m_charAnimator = GetComponentInChildren<Animator>();
        m_interactionText = GetInteractText.Instance.m_interactionText;
        m_cam = Camera.main.gameObject;
        m_nameObject = transform.GetChild(0).gameObject;
        m_player = GameObject.Find("Sam'sTempCharacterController/Player");
        //Null check
        if (m_nameObject.GetComponentInChildren<TextMesh>())
        {
            m_nameObject.GetComponentInChildren<TextMesh>().text = m_name;
            m_nameObject.GetComponentInChildren<TextMesh>().color = m_nameColour;
        }
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        if (m_navMeshAgent == null)
        {
            Debug.LogWarning("Warning: Unable to locate NPC's NavMeshAgent component.");
        }
        m_navMeshAgent.speed = m_speed;

    }

    private void Update()
    {
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
            case NPCStates.NPC_NOMOVE:
                //DO NOTHING
                break;
            default:
                break;
        }
        InteractionTrigger();
        Interaction();
    }

    private void ContinueUI()
    {
        if (m_isTalking)
        {
            m_continueTextUI.SetActive(false);
            //Pause the player
            m_player.GetComponent<PlayerControls>().enabled = false;
        }
        else
        {
            m_continueTextUI.SetActive(true);
            //Unpause
            m_player.GetComponent<PlayerControls>().enabled = true;
        }
    }

    public Voice GetNPCVoiceType()
    {
        Debug.Log("charvoice" + charVoice);
        return charVoice;
    }

    private void InteractionTrigger()
    {
        if (m_inRangeOfPlayer && m_interacted)
        {
            m_interactionText.SetActive(false);
            m_currentState = NPCStates.NPC_INTERACT;
            m_interacted = false;
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

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_inRangeOfPlayer = true;
            m_interactionText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to talk.";
            m_interactionText.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //incase the player intereacts but manages to be out of range
            m_player.GetComponent<PlayerControls>().enabled = true;
            if (m_currentState == NPCStates.NPC_INTERACT)
            {
                m_currentState = NPCStates.NPC_FINDLOCATION;
            }

            m_inRangeOfPlayer = false;
            m_interactionText.SetActive(false);
        }
    }

    //public void InteractKey(InputAction.CallbackContext ctx)
    //{
    //    if (ctx.performed)
    //    {
    //        if (m_inRangeOfPlayer)
    //        {
    //            m_interacted = true;
    //        }
    //    }
    //}

    private void Interaction()
    {
        if (m_inputSystem.Player.Interact.triggered)
        {
            if (m_inRangeOfPlayer)
            {
                m_interacted = true;

            }
        }
    }

    //////////////////////////////////////////////////
    //// Functions - States
    private void FindLocation()
    {
        m_randPosition = RandomNavSphere(transform.position, m_wanderRadius, -1);
        m_destination = m_randPosition;
        SetDestination();
        m_currentState = NPCStates.NPC_WALKTOLOCATION;
        m_charAnimator.SetBool("isWalking", true);
    }
    private void WalkToLocation()
    {
        if (Vector3.Distance(transform.position, m_destination) < 1.5f)
        {
            //m_currentState = NPCStates.NPC_INTERACT;
            m_currentState = NPCStates.NPC_FINDLOCATION;
            m_charAnimator.SetBool("isWalking", false);
        }
        else if(m_navMeshAgent.velocity == Vector3.zero)
        {
            m_currentState = NPCStates.NPC_FINDLOCATION;
        }
    }
    private void InteractedWith()
    {
        m_waitTimer = 1.0f;
        m_currentState = NPCStates.NPC_WAITFORPLAYER;
        m_charAnimator.SetBool("isWalking", false);
        m_index = Random.Range(0, m_dialogue.Length);
        m_interactionText.GetComponent<TextMeshProUGUI>().text = m_dialogue[m_index];
        m_interactionText.SetActive(true);
        m_isTalking = true;
        CheckQuest();
    }

    private void CheckQuest()
    {
        if(QuestManager.Instance.CurrentQuestGiver() == null)
        {
            return;
        }
        else if(QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().name == "SB_SpeakQuest")
        {
            QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().SetCompleted(true);
        }
    }

    private void WaitForPlayerInput()
    {
        //TO DO
        //  Look at player
        //  Dialogue pops up on screen
        Vector3 m_lookAt = new Vector3(m_player.transform.position.x, transform.position.y, m_player.transform.position.z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(m_lookAt), Time.deltaTime * 2.5f);
        m_navMeshAgent.isStopped = true;
        m_charAnimator.SetBool("isWalking", false);
        ContinueUI();

        if (m_interactionText.GetComponent<TextMeshProUGUI>().text == m_dialogue[m_index])
        {
            m_isTalking = false;
            if (Input.anyKeyDown)
            {
                m_currentState = NPCStates.NPC_FINDLOCATION;
                m_interactionText.SetActive(false);
                m_continueTextUI.SetActive(false);
                m_navMeshAgent.isStopped = false;
            }
        }
        else
        {
            m_isTalking = true;
            m_waitTimer -= Time.deltaTime;
        }
    }

    private enum NPCStates
    {
        NPC_FINDLOCATION,
        NPC_WALKTOLOCATION,
        NPC_INTERACT,
        NPC_WAITFORPLAYER,
        NPC_NOMOVE
    };
}