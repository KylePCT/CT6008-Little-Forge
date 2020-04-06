//////////////////////////////////////////////////
/// File: FiringWeapon.cs
/// Author: Sam Baker
/// Date created: 01/03/20
/// Last edit: 01/03/20
/// Description: Script to control the firing off a weapon.
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class FiringWeapon : MonoBehaviour
{
    [Header(" > Weapon Parameters:")]
    [Space(-10)]
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > Left Mouse Button.")]
    [Space(-10)]
    [Header("FiringWeapon's functions")]

    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private bool m_weaponEnabled = true;
    [SerializeField] private float m_fireRate = 0.2f;
    private float m_timer = 0.0f;
    [SerializeField] private float m_damage = 10.0f;
    private float m_actaulDamage = 0.0f;
    [SerializeField] [Range(0.01f, 0.99f)] private float m_dmgVariation = 0.2f;
    private bool m_isFiring = false;
    private GameObject m_cam = null;


    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_cam = GameObject.Find("Sam'sTempCharacterController/PlayerOrientation/MainCamera");
        m_damage = m_damage + KT_LevelSystem.Instance.GetStats().maxStrength;
    }

    private void Update()
    {
        ShouldFire();
    }

    private void ShouldFire()
    {
        if (m_isFiring)
        {
            if (m_weaponEnabled)
            {
                

                m_timer -= Time.deltaTime;

                if(m_timer <= 0)
                {
                    //FIX - player could shoot while zoomed out if zoom was untoggled while shooting.
                    if(!PlayerZoom.Instance.GetZoom())
                    {
                        return;
                    }

                    //MUZZLE FLASH TRIGGERS HERE....................

                    //Damage range
                    m_actaulDamage = Random.Range(m_damage * ( 1 - m_dmgVariation), m_damage * (1 + m_dmgVariation));

                    RaycastHit hit;
                    if (Physics.Raycast(m_cam.transform.position, m_cam.transform.forward, out hit, 100.0f))
                    {
                        //Impact
                        //Check to see if impacted object has health.
                        if (hit.transform.gameObject.GetComponent<ObjectHealth>() != null)
                        {
                            Debug.Log(hit.transform.name);
                            hit.transform.gameObject.GetComponent<ObjectHealth>().TakeDamage(m_actaulDamage);
                        }

                    }
                    m_timer = m_fireRate;
                }
                

            }
        }
    }

    public void FireTrigger(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (m_isFiring)
            {
                m_isFiring = false;
            }
            else
            {
                m_isFiring = true;

                if (m_weaponEnabled)
                {
                    m_timer = m_fireRate;
                }
            }
        }
    }

    public void SetWeaponActive(bool a_true) => m_weaponEnabled = a_true;

    public void SetDamage(float dmg)
    {
        m_damage = m_damage + dmg;
    }
}
