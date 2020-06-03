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
    [SerializeField] [Range(0.01f, 0.6f)] private float m_rotSensitivity = .2f;
    private Transform m_player = null;
    private GameObject m_playerObject = null;
    private GameObject m_rotFaceObject = null;
    [SerializeField] private float m_minAngle = -50;
    [SerializeField] private float m_maxAngle = 0;
    private float m_yaw = 0.0f;
    private float m_pitch = 0.0f;
    private PlayerZoom m_pZoom = null;
    private InputSystem m_inputSystem = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();

    private void Start()
    {
        if (GameObject.Find("Sam'sTempCharacterController/Player"))
        {
            m_playerObject = GameObject.Find("Sam'sTempCharacterController/Player");
            m_player = m_playerObject.transform;
        }
        if (GameObject.Find("Sam'sTempCharacterController/Player").GetComponent<PlayerZoom>())
        {
            m_pZoom = GameObject.Find("Sam'sTempCharacterController/Player").GetComponent<PlayerZoom>();
        }
        if (GameObject.Find("SB_RotFace"))
        {
            m_rotFaceObject = GameObject.Find("SB_RotFace");
        }
        m_rotSensitivity = .2f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if(OptionsData.Instance.GetSensitivity() > 0.6f || OptionsData.Instance.GetSensitivity() < 0.01f)
        {
            m_rotSensitivity = .2f;
        }
        else
        {
            m_rotSensitivity = OptionsData.Instance.GetSensitivity();
        }
        var moveInput = m_inputSystem.Player.Movement.ReadValue<Vector2>();

        Vector3 rotF = transform.forward;
        Vector3 rotR = transform.right;
        rotF.y = 0;
        rotR.y = 0;
        rotF = rotF.normalized;
        rotR = rotR.normalized;
        if (moveInput.x != 0 || moveInput.y != 0)
        {
            m_rotFaceObject.transform.position = transform.position + (rotF * moveInput.y + rotR * moveInput.x) * 150 * Time.deltaTime;
        }
        transform.position = m_player.position;
        if (m_pZoom.GetZoom())
        {
            Vector3 playerYRot = m_player.transform.eulerAngles;
            playerYRot.y = transform.eulerAngles.y;
            m_player.transform.eulerAngles = playerYRot;
        }
        else
        {
            if (moveInput.x != 0 || moveInput.y != 0)
            {
                Vector3 relativePos = m_rotFaceObject.transform.position - m_playerObject.transform.position;
                Quaternion toRotation = Quaternion.LookRotation(relativePos);
                m_playerObject.transform.rotation = Quaternion.Lerp(m_playerObject.transform.rotation, toRotation, 5 * Time.deltaTime);
            }
        }
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