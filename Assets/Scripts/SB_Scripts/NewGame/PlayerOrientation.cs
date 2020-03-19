//////////////////////////////////////////////////
/// File: PlayerOrientation.cs
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

public class PlayerOrientation : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] [Range(0.1f, 0.6f)] private float m_rotSensitivity = .2f;
    private Transform m_player = null;
    [SerializeField] private float m_minAngle = -50;
    [SerializeField] private float m_maxAngle = 0;
    private float m_yaw = 0.0f;
    private float m_pitch = 0.0f;
    private InputSystem m_inputSystem = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();

    private void Start()
    {
        m_player = GameObject.Find("Sam'sTempCharacterController/Player").transform;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        transform.position = m_player.position;

        //Make player face camera always ??? can change if prefered any other way
        Vector3 playerYRot = m_player.transform.eulerAngles;
        playerYRot.y = transform.eulerAngles.y;
        m_player.transform.eulerAngles = playerYRot;

        Rotate();
    }

    private void Rotate()
    {
        var rotationInput = m_inputSystem.Player.Rotation.ReadValue<Vector2>();

        m_yaw += m_rotSensitivity * rotationInput.x;
        m_pitch -= m_rotSensitivity * rotationInput.y;

        //Props to Blondy here
        m_pitch = Mathf.Clamp(m_pitch, m_minAngle, m_maxAngle);

        transform.eulerAngles = new Vector3(m_pitch, m_yaw, 0);
    }
}