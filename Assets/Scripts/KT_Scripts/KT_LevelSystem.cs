using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KT_LevelSystem : MonoBehaviour
{
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

    public Level[] levels;

    public void Start()
    {

        Instance = this; //by defining this you can call the singleton instance from anywhere in the code as KT_LevelSystem.Instance.gainXp(amount);

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjectHealth>();

        currentXP = 1;
        currentLevel = 0; //Example on getting a level object from the array instead of a single value
        xpToNextLevel = 300;

        xpUI.text = "XP:" + currentXP;
        levelUI.text = "Level: " + currentLevel;

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

[System.Serializable]
public class CharLevel
{
    public int requiredXP;

    public int maxHealth;
    public int baseDamage;
}

