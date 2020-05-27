//////////////////////////////////////////////////
/// File: ObjectHealth.cs
/// Author: Sam Baker
/// Date created: 01/03/20
/// Last edit: 01/03/20
/// Description: Script that can be placed on any object that can be destroyed.
/// Comments: 
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
    [SerializeField] private float m_maxHealth = 100f;
    private float m_currentHealth = 0f;
    [SerializeField] private bool m_hasHealthBar = false;
    [SerializeField] private GameObject m_dmgIndication = null;
    private Image m_healthBar = null;
    private GameObject m_healthCanvas = null;
    private GameObject m_cam = null;
    public GameObject m_slimeItemDrop;
    private KT_SpawnEnemies m_spawner = null;
    public GameObject celebratePS;
    private bool m_dead = false;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        if (m_currentHealth != m_maxHealth)
        {
            m_currentHealth = m_startHealth;
        }
        m_cam = GameObject.Find("Sam'sTempCharacterController/PlayerOrientation/MainCamera");
        if (m_hasHealthBar)
        {
            m_healthBar = gameObject.transform.Find("Canvas").transform.Find("Health").GetComponent<Image>();
            m_healthCanvas = gameObject.transform.Find("Canvas").gameObject;
        }
    }

    private void Update()
    {
        if (m_hasHealthBar)
        {
            UpdateHealthLookAt();
        }
    }

    private void UpdateHealthLookAt()
    {
        Vector3 v = m_cam.transform.position - m_healthCanvas.transform.position;
        v.x = v.z = 0.0f;
        m_healthCanvas.transform.LookAt(m_cam.transform.position - v);
    }

    private void UpdateNoHealth()
    {
        if (m_currentHealth <= 0)
        {
            if (gameObject.transform.tag == "Player")
            {
                SceneManager.LoadScene("Hub");
            }
            else if (gameObject.transform.tag == "Enemy")
            {
                if (!m_dead)
                {
                    Destroy(gameObject);
                    Instantiate(celebratePS, transform.position, Quaternion.Euler(-90, 0, 0));

                    //10xp gained for killing enemy
                    KT_LevelSystem.Instance.gainXP(10);
                    Instantiate(m_slimeItemDrop, transform.position, Quaternion.identity);
                    KT_AudioManager.instance.playSound("SlimeDead");
                    m_spawner.EnemyHasDied();
                    m_dead = true;
                }
                if (QuestManager.Instance.CurrentQuestGiver() == null)
                {
                    return;
                }
                else if (QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().name == "SB_KillSlime")
                {
                    QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().SetCompleted(true);
                }
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void UpdateHealth()
    {
        m_healthBar.fillAmount = m_currentHealth / m_startHealth;
    }

    private void ShowDamage(float a_fdmg)
    {
        Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y+0.5f, transform.position.z + Random.Range(-0.5f, 0.5f));
        GameObject dmgIndication = Instantiate(m_dmgIndication, spawnPos, Quaternion.identity);
        dmgIndication.transform.LookAt(m_cam.transform);

        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().fontSize = 32;
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().text = a_fdmg.ToString("n0");
        Destroy(dmgIndication, 0.25f);
    }

    public void TakeDamage(float a_fvalue)
    {
        m_currentHealth -= a_fvalue;
        if (m_hasHealthBar)
        {
            UpdateHealth();
            ShowDamage(a_fvalue);
        }
        UpdateNoHealth();
    }
    public float GetHealth() => m_currentHealth;

    public void SetMaxHealth(int a_maxHealth) => m_maxHealth = a_maxHealth;

    public void GiveMaxHealth()
    {
        m_currentHealth = m_maxHealth;
    }

    public void SetSpawner(KT_SpawnEnemies a_spawner)
    {
        m_spawner = a_spawner;
    }
}
