//////////////////////////////////////////////////
/// File: PlayerControls.cs
/// Author: Sam Baker
/// Date created: 28/02/20
/// Last edit: 11/03/2020 by Kyle Tugwell (Adding Animations)
/// Description: Main player controls.
/// Comments:
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [Header("Player Parameters")]
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > RightMouseBut - Zoom")]
    [Space(-10)]
    [Header(" > 'F'- Intereact")]
    [Space(-10)]
    [Header(" > Space - Jump")]
    [Space(-10)]
    [Header(" > WSAD & MOUSE - Move & Look")]
    [Space(-10)]
    [Header("CONTROLS")]

    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private float m_moveSpeed = 2.5f;
    [SerializeField] private bool m_isGrounded = true;
    [SerializeField] private GameObject m_playerOrientation = null;
    private Vector3 m_moveDirection = Vector3.zero;
    private CharacterController m_controller;
    [SerializeField] private float m_jumpHeight = 2f;
    private float m_gravity = -10f;
    private float m_yAxisVelocity = 0;
    private TextMesh m_healthInd = null;
    private InputSystem m_inputSystem = null;

    Animator charAnimator;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable(); 

    private void Start()
    {
        m_healthInd = gameObject.transform.Find("Health").GetComponent<TextMesh>();
        m_controller = this.GetComponent<CharacterController>();
        m_playerOrientation = GameObject.Find("Sam'sTempCharacterController/PlayerOrientation");

        charAnimator = GetComponentInChildren<Animator>();

    }

    private void Update()
    {
        Movement();
        m_healthInd.text = GetComponent<ObjectHealth>().GetHealth().ToString("n0");
    }

    private void Movement()
    {
        var moveInput = m_inputSystem.Player.Movement.ReadValue<Vector2>();
        //var zoomInput = m_inputSystem.Player.Zoom.ReadValue<bool>();

        Vector3 rotF = m_playerOrientation.transform.forward;
        Vector3 rotR = m_playerOrientation.transform.right;
        rotF.y = 0;
        rotR.y = 0;
        rotF = rotF.normalized;
        rotR = rotR.normalized;

        m_moveDirection = (rotF * moveInput.y + rotR * moveInput.x) * m_moveSpeed;

        m_yAxisVelocity += m_gravity * Time.deltaTime;
        m_moveDirection.y = m_yAxisVelocity;

        m_moveDirection *= Time.deltaTime;
        m_controller.Move(m_moveDirection);

        if (moveInput.x != 0f || moveInput.y != 0f)
        {
            charAnimator.SetBool("isWalking", true);
        }

        else
        {
            charAnimator.SetBool("isWalking", false);
        }
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_isGrounded)
            {
                m_yAxisVelocity = Mathf.Sqrt(m_jumpHeight * -2f * m_gravity);
                m_isGrounded = false;

                charAnimator.SetBool("isJumping", true);

            }

            else
            {
                charAnimator.SetBool("isWalking", false);
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Ground")
        {
            m_isGrounded = true;
            m_yAxisVelocity = -0.5f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ground")
        {
            m_isGrounded = false;
        }
    }
}