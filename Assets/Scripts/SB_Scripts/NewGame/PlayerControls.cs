//////////////////////////////////////////////////
/// File: PlayerControls.cs
/// Author: Sam Baker
/// Date created: 28/02/20
/// Last edit: 28/02/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private GameObject m_playerOrientation = null;
    private Vector3 m_moveDirection = Vector3.zero;
    [Header("Player Parameters")]
    [SerializeField] private float m_moveSpeed = 2.5f;
    [SerializeField]private bool m_isGrounded = true;
    private CharacterController m_controller;
    private InputSystem m_inputSystem = null;
    [SerializeField] private float m_jumpHeight = 3f;
    private float m_gravity = -5f;
    private float m_yAxisVelocity = 0;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    private void OnEnable() => m_inputSystem.Player.Enable();
    private void OnDisable() => m_inputSystem.Player.Disable();

    private void Start()
    {
        m_controller = GetComponent<CharacterController>();
        m_playerOrientation = GameObject.Find("Sam'sTempCharacterController/PlayerOrientation");
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        var moveInput = m_inputSystem.Player.Movement.ReadValue<Vector2>();

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
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_isGrounded)
            {
                m_yAxisVelocity = Mathf.Sqrt(m_jumpHeight * -2f * m_gravity);
                m_isGrounded = false;
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
