//Sam Baker
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Health player;
    public Weapon weapon;
    public Health boss;
    public Image healthIndication;
    public Image chargeIndication;
    public Image bossHealthIndication;
    public Image[] m_weaponUI = new Image[3];
    private float startHealth;
    private float startCharge;
    private float startBossHealth;

    private void Start()
    {
        if(player == null)
        {
            if(GameObject.FindGameObjectWithTag("Player"))
            {
                player = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
            } else
            {
                Debug.LogError("Error: The gameobject tagged 'Player' cannot be found in the scene.");
            }
        }
        startHealth = player.startHealth;
        startBossHealth = boss.startHealth;
    }

    private void Update()
    {
        healthIndication.fillAmount = player.currentHealth / startHealth;
        chargeIndication.fillAmount = weapon.weaponCharge / 100;
        if (boss != null)
        {
            bossHealthIndication.fillAmount = boss.currentHealth / startBossHealth;
        }

        //Sort this to detect and execute when the weapon has been changed. Not constantly
        UpdateWeaponUI();
    }

    private void UpdateWeaponUI()
    {
        foreach (Image wUI in m_weaponUI)
        {
            wUI.color = Color.grey;
        }
        m_weaponUI[(int)weapon.weaponType].color = Color.white;
    }
}
