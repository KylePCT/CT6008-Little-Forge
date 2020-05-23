//////////////////////////////////////////////////
/// File: KT_LevelSystem.cs
/// Author: Kyle Tugwell/Sam Baker
/// Date created: 06/04/20
/// Last edit: 08/04/20
/// Description: An XP and Level system.
/// Comments: Assisted in finishing the script all data is read from 
///         the getstats and operates in game - Sam Baker
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

    private int playerLevel = 0;

    public Image xpBarImage;

    private SaveSlot m_save = null;

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

    [Header("and ends at 10")]
    [Space(-10)]
    [Header("Level starts at 0")]
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
        if (SaveGameManager.GetMainCharFile() != null)
        {
            m_save = SaveGameManager.GetMainCharFile();
            currentLevel = m_save.m_level;
            currentXP = m_save.m_xp;
            UIUpdate();
        }
        else
        {
            //You must be starting the game from the hub!!!
            //Nothing wrong here let the game continue.
            currentXP = 0;
            currentLevel = 0;
        }

        player = GetComponent<ObjectHealth>();

        //Set parameters
        //Example on getting a level object from the array instead of a single value
        xpToNextLevel = GetStats().requiredXP;

        //TMP assigning
        xpUI.text = "XP:" + currentXP;
        levelUI.text = "Level: " + currentLevel;

        //refer to Player class and get Health value
        health = player.GetHealth();

        player.SetMaxHealth(GetStats().maxHealth);
        player.GiveMaxHealth();

        UIUpdate();
        player.GiveMaxHealth();
    }

    public void Update()
    {
        UIUpdate();
        ////DEBUG SETTING
        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    Debug.Log("XP yeet");
        //    //currentXP = currentXP + 50;
        //    gainXP(50);

        //    UIUpdate();
        //}

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
        SaveLevel();
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

    private void SaveLevel()
    {
        if (m_save != null)
        {
            m_save.m_level = currentLevel;
            m_save.m_xp = currentXP;
            SaveGameManager.SaveCharacter(m_save);
        }
    }
}

