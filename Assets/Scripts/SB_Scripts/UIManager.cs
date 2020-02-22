//Sam Baker
using System;
using UnityEngine;
using UnityEngine.InputSystem;
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
    private int weaponID;

    private Controls controls = null;

    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start()
    {
        weaponID = (int)weapon.weaponType;
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
        UpdateWeaponUI();
    }

    private void Update()
    {
        healthIndication.fillAmount = player.currentHealth / startHealth;
        chargeIndication.fillAmount = weapon.weaponCharge / 100;
        if (boss != null)
        {
            bossHealthIndication.fillAmount = boss.currentHealth / startBossHealth;
        }
    }

    private void UpdateWeaponUI()
    {
        foreach (Image wUI in m_weaponUI)
        {
            wUI.color = Color.grey;
        }
        m_weaponUI[(int)weapon.weaponType].color = Color.white;
    }

    //L1
    public void ChangeWeaponUp(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            weaponID -= 1;
            if(weaponID <= -1)
            {
                weaponID = 2;
            }
            weapon.weaponType = (Weapon.WEAPON_TYPE)weaponID;
            UpdateWeaponUI();
        }
    }

    //R1
    public void ChangeWeaponDown(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (ctx.performed)
            {
                weaponID += 1;
                if (weaponID >= 3)
                {
                    weaponID = 0;
                }
            }
            weapon.weaponType = (Weapon.WEAPON_TYPE)weaponID;
            UpdateWeaponUI();
        }
    }
}
