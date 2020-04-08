//////////////////////////////////////////////////
/// File: KT_LevelSystem.cs
/// Author: Kyle Tugwell
/// Date created: 06/04/20
/// Last edit: 06/04/20
/// Description: An XP and Level system.
/// Comments: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class KT_LevelSystem : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    private int currentXP;
    private int currentLevel;
    private int xpToNextLevel;
    private float health;
    private float damage;

    private float xpUIPercentage;

    private ObjectHealth player;

    private int playerLevel;

    public Image xpBarImage;


    public static KT_LevelSystem m_instance;
    public static KT_LevelSystem Instance { get { return m_instance; } }

    [SerializeField] private TextMeshProUGUI xpUI;
    [SerializeField] private TextMeshProUGUI levelUI;

    //////////////////////////////////////////////////
    //// Functions
 
    //Struct allows for levels array to contain these parameters to customise
    [System.Serializable]
    public struct Level
    {
        public int requiredXP;

        public int maxHealth;
        public int baseDamage;
    }

    //Level array
    public Level[] levels;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;
        }
    }

    public void Start()
    {

        player = GetComponent<ObjectHealth>();

        //Set parameters
        currentXP = 0;
        currentLevel = 0; //Example on getting a level object from the array instead of a single value
        xpToNextLevel = GetStats().requiredXP;

        //TMP assigning
        xpUI.text = "XP:" + currentXP;
        levelUI.text = "Level: " + currentLevel;

        //refer to Player class and get Health value
        health = player.GetHealth();

        player.SetMaxHealth(GetStats().maxHealth);
        player.GiveMaxHealth();

        UIUpdate();
    }

    public void Update()
    {
        UIUpdate();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("XP yeet");
            //currentXP = currentXP + 50;
            gainXP(50);

            UIUpdate();
        }
        Debug.Log(GetStats().baseDamage);

        //xpUIPercentage = (xpToNextLevel - currentXP) / 100;
    }

    //if the current XP is higher than the xp needed to level up, level up the player and reset
    public void gainXP(int xp)
    {
        if (currentLevel < 10)
        {
            currentXP += xp;
            if (currentXP >= xpToNextLevel)
            {
                currentXP -= xpToNextLevel;
                xpToNextLevel = GetStats().requiredXP;
                OnLevelUp();
            }
        }
        
        UIUpdate();
    }

    public void OnLevelUp()
    {
        currentLevel++;
        playerLevel = currentLevel;
        HealthUpdate();
    }
    private void HealthUpdate()
    {
        player.SetMaxHealth(GetStats().maxHealth);
        player.GiveMaxHealth();
    }

    //update UI
    public void UIUpdate()
    {
        xpUIPercentage = ((float)currentXP / (float)xpToNextLevel);
        if (currentLevel < 10)
        {
            xpUI.text = "XP: " + currentXP;
            levelUI.text = "Level: " + currentLevel;
        }
        else
        {
            xpUI.text = "XP: MAX";
            levelUI.text = "Level: " + currentLevel;
            xpUIPercentage = 1;
        }
        xpBarImage.fillAmount = xpUIPercentage;
    }

    public Level GetStats()
    {
        return levels[currentLevel];
    }
}

