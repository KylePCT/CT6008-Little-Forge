//////////////////////////////////////////////////
/// File: ObjectHealth.cs
/// Author: Sam Baker
/// Date created: 1/03/20
/// Last edit: 1/03/20
/// Description: Script that can be placed on any object that can be destroyed.
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectHealth : MonoBehaviour
{
    [Header("Health Parameters:")]
    [Space(-10)]
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header("     can be destroyed.")]
    [Space(-15)]
    [Header(" > Can be placed on any object that")]
    [Space(-10)]
    [Header("ObjectHealth's functions")]
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private float m_startHealth = 100f;
     private float m_currentHealth = 0f;
    [SerializeField] private bool m_hasHealthBar = false;
    private GameObject m_healthBar = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_currentHealth = m_startHealth;
        if(m_hasHealthBar)
        {
            m_healthBar = gameObject.transform.Find("Canvas").transform.Find("Health").gameObject;
        }
    }

    private void Update()
    {
        if (m_currentHealth <= 0)
        {
            if (gameObject.transform.tag == "Player")
            {
                //Restart the scene
                //     or whatever happens when the player dies..................
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void UpdateHealth()
    {
        m_healthBar.GetComponent<Image>().fillAmount = m_currentHealth / m_startHealth;
    }

    public void TakeDamage(float a_fvalue)
    {
        m_currentHealth -= a_fvalue;
        if (m_hasHealthBar)
        {
            UpdateHealth();
        }
    }
}
