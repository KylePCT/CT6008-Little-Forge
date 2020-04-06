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

    public static KT_LevelSystem Instance;

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

    public void Start()
    {

        Instance = this; //by defining this you can call the singleton instance from anywhere in the code as KT_LevelSystem.Instance.gainXp(amount);

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjectHealth>();

        //Set parameters
        currentXP = 1;
        currentLevel = 0; //Example on getting a level object from the array instead of a single value
        xpToNextLevel = 300;

        //TMP assigning
        xpUI.text = "XP:" + currentXP;
        levelUI.text = "Level: " + currentLevel;

        //refer to Player class and get Health value
        health = player.GetHealth();

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("XP yeet");
            currentXP = currentXP + 50;

            UIUpdate();
        }

        xpUIPercentage = (xpToNextLevel - currentXP) / 100;
    }

    //if the current XP is higher than the xp needed to level up, level up the player and reset
    public void gainXP(int xp)
    {
        currentXP += xp;
        if (currentXP >= xpToNextLevel)
        {
            currentLevel++;
            currentXP -= xpToNextLevel;
        }

        UIUpdate();
    }

    public void OnLevelUp()
    {
        currentLevel++;
        playerLevel = currentLevel;
    }

    //update UI
    public void UIUpdate()
    {
        xpUI.text = "XP: " + currentXP;
        levelUI.text = "Level: " + currentLevel;
    }

    public Level GetStats()
    {
        return levels[currentLevel];
    }
}

