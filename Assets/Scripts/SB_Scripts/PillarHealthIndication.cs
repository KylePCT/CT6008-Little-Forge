//////////////////////////////////////////////////
/// File: PillarHealthIndication.cs
/// Author: Sam Baker
/// Date created: 19/02/20
/// Last edit: 19/02/20
/// Description: Used to display the current health of each pillar.
/// Comments:
//////////////////////////////////////////////////

using System;
using UnityEngine;
using UnityEngine.UI;

public class PillarHealthIndication : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    public Camera m_cam;
    private Health m_health;
    private float m_startHealth;
    private float m_currentHealth;
    public Image m_healthBar;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_health = gameObject.transform.parent.GetComponent<Health>();
        m_startHealth = m_health.startHealth;
        m_cam = Camera.main;
    }

    private void Update()
    {
        UpdatePillarHealth();

        UpdateLookingAngle();
    }

    private void UpdateLookingAngle()
    {
        Vector3 v = m_cam.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(m_cam.transform.position - v);
    }

    private void UpdatePillarHealth()
    {
        m_currentHealth = m_health.currentHealth;
        m_healthBar.fillAmount = m_currentHealth / m_startHealth;
    }
}
