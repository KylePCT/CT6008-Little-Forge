﻿//////////////////////////////////////////////////
/// File: PlayerZoom.cs
/// Author: Sam Baker
/// Date created: 28/02/20
/// Last edit: 28/02/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerZoom : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private GameObject m_cam = null;
    private Vector3 m_origPos = Vector3.zero;
    private Quaternion m_origRot = Quaternion.Euler(0,0,0);
    private bool m_zoomIn = false;
    [SerializeField] private float zoomSpeed = 5.0f;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_cam = GameObject.Find("---- ESSENTIALS/Sam'sTempCharacterController/PlayerOrientation/MainCamera");
        m_origPos = m_cam.transform.localPosition;
    }

    private void Update()
    {
        if (m_zoomIn)
        {
            m_cam.transform.localPosition = Vector3.Lerp(m_cam.transform.localPosition, new Vector3(0.5f, 0.7f, -1.5f), zoomSpeed * Time.deltaTime);
        }
        else
        {
            m_cam.transform.localPosition = Vector3.Lerp(m_cam.transform.localPosition, m_origPos, zoomSpeed * Time.deltaTime);
        }
    }

    public void ZoomIn(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_zoomIn)
            {
                //ZoomOut
                m_cam.transform.localRotation = m_origRot;
                m_zoomIn = false;
            }
            else
            {
                //ZoomIn
                m_origRot = m_cam.transform.localRotation;
                m_cam.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                m_zoomIn = true;
            }
        }
    }
}
