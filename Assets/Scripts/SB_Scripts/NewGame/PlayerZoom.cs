//////////////////////////////////////////////////
/// File: PlayerZoom.cs
/// Author: Sam Baker
/// Date created: 28/02/20
/// Last edit: 11/03/20 by Kyle Tugwell
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerZoom : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private static PlayerZoom m_instance;
    public static PlayerZoom Instance { get { return m_instance; } }

    private GameObject m_cam = null;
    private Vector3 m_origPos = Vector3.zero;
    private Quaternion m_origRot = Quaternion.Euler(0, 0, 0);
    private bool m_zoomIn = false;
    [SerializeField] private float zoomSpeed = 5.0f;

    Animator charAnimator;
    public GameObject gun;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake()
    {
        m_instance = this;
    }
    private void Start()
    {
        m_cam = GameObject.Find("Sam'sTempCharacterController/PlayerOrientation/MainCamera");
        m_origPos = m_cam.transform.localPosition;
        charAnimator = GetComponentInChildren<Animator>();

        gun.SetActive(false);

    }

    private void Update()
    {

        if (m_zoomIn)
        {
            m_cam.transform.localPosition = Vector3.Lerp(m_cam.transform.localPosition, new Vector3(0.5f, 0.7f, -1.5f), zoomSpeed * Time.deltaTime);

            charAnimator.SetBool("isShooting", true);
            gun.SetActive(true);

        }
        else
        {
            m_cam.transform.localPosition = Vector3.Lerp(m_cam.transform.localPosition, m_origPos, zoomSpeed * Time.deltaTime);

            charAnimator.SetBool("isShooting", false);
            gun.SetActive(false);

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

    public void SetZoom(bool a_true) => m_zoomIn = a_true;

    public bool GetZoom() => m_zoomIn;
}