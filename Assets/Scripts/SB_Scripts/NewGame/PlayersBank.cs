//////////////////////////////////////////////////
/// File: PlayersBank.cs
/// Author: Sam Baker
/// Date created: 27/02/20
/// Last edit: 27/02/20
/// Description: Singleton, PlayerBanks is used to manage the player currency. The PlayersBank instance
///         can be called and a set of functions are available to modifiy the currency.
/// Comments: This script needs to be attatched to an object in the starting scene.
///         *THE CURRENY IS A FLOAT, was an int but not anymore ;)*
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersBank : MonoBehaviour
{
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > PlayersBank.Instance.GetMoney();")]
    [Space(-10)]
    [Header(" > PlayersBank.Instance.SetMoney(float);")]
    [Space(-10)]
    [Header(" > PlayersBank.Instance.ResetMoney();")]
    [Space(-10)]
    [Header(" > PlayersBank.Instance.TakeAwayMoney(float);")]
    [Space(-10)]
    [Header(" > PlayersBank.Instance.AddMoney(float);")]
    [Space(-10)]
    [Header("PlayersBank's functions")]
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private float m_playersMoney = 0;
    private float m_playersIngots = 0;
    private SaveSlot m_save = null;
    private static PlayersBank m_instance;
    public static PlayersBank Instance { get { return m_instance; } }

    //////////////////////////////////////////////////
    //// Functions
    private void Awake()
    {
        m_instance = this;
    }

    private void Start()
    {
        if (SaveGameManager.GetMainCharFile() != null)
        {
            m_save = SaveGameManager.GetMainCharFile();
            m_playersMoney = m_save.m_money;
            m_playersIngots = m_save.m_ingots;
        }
        else
        {
            //You must be starting the game from the hub!!!
            //SET MONEY FOR DEBUG
            SetMoney(9999999);
            SetIngots(9999999);
        }

    }

    ////////////////////////////////////////////////////
    /// CURRENCY
    ////////////////////////////////////////////////////

    /// <summary>
    /// Function inside the PlayersBank.cs, used to increase the amount of money in the players bank.
    /// </summary>
    /// <param name="a_money">Amount to add to the players bank</param>
    public void AddMoney(float a_money)
    {
        m_playersMoney += a_money;
        SaveMoney();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to decrease the amount of money in the players bank.
    /// </summary>
    /// <param name="a_money">Amount to takeaway from the players bank</param>
    public bool TakeAwayMoney(float a_money)
    {
        if ((m_playersMoney - a_money) < 0)
        {
            Debug.LogWarning("Warning: Player does not have enough currency to purchase item!");
            return false;
        }
        m_playersMoney -= a_money;
        SaveMoney();
        return true;
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to reset the amount of money in the players bank.
    /// </summary>
    public void ResetMoney()
    {
        m_playersMoney = 0;
        SaveMoney();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to set the players money to a specific amount.
    /// </summary>
    /// <param name="a_money">The specific amount to be set</param>
    public void SetMoney(float a_money)
    {
        if (a_money < 0)
        {
            Debug.LogWarning("Warning: Player can not have minus currency!");
            return;
        }
        m_playersMoney = a_money;
        SaveMoney();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to get the players current money.
    /// </summary>
    /// <returns>The int of the players currency is returned.</returns>
    public float GetMoney()
    {
        return m_playersMoney;
    }
    /// <summary>
    /// Function used to save the players currency
    /// </summary>
    public void SaveMoney()
    {
        if (m_save != null)
        {
            m_save.m_money = m_playersMoney;
            SaveGameManager.SaveCharacter(m_save);
        }
    }

    ////////////////////////////////////////////////////
    /// INGOTS
    //////////////////////////////////////////////////// 

    /// <summary>
    /// Function inside the PlayersBank.cs, used to increase the amount of ingots in the players bank.
    /// </summary>
    /// <param name="a_ingots">Amount to add to the players bank</param>
    public void AddIngots(float a_ingots)
    {
        m_playersIngots += a_ingots;
        SaveIngots();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to decrease the amount of money in the players bank.
    /// </summary>
    /// <param name="a_ingots">Amount to takeaway from the players ingots bank</param>
    public void TakeAwayIngots(float a_ingots)
    {
        if ((m_playersIngots - a_ingots) < 0)
        {
            Debug.LogWarning("Warning: Player does not have enough ingots");
            return;
        }
        m_playersIngots -= a_ingots;
        SaveIngots();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to reset the amount of ingots in the players bank.
    /// </summary>
    public void ResetIngots()
    {
        m_playersIngots = 0;
        SaveIngots();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to set the players ingots to a specific amount.
    /// </summary>
    /// <param name="a_ingots">The specific amount to be set (ingots)</param>
    public void SetIngots(float a_ingots)
    {
        if (a_ingots < 0)
        {
            Debug.LogWarning("Warning: Player can not have minus ingots!");
            return;
        }
        m_playersIngots = a_ingots;
        SaveIngots();
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to get the players current ingots.
    /// </summary>
    /// <returns>The int of the players ingots is returned.</returns>
    public float GetIngots()
    {
        return m_playersIngots;
    }
    /// <summary>
    /// Function used to save the players ingots
    /// </summary>
    public void SaveIngots()
    {
        if (m_save != null)
        {
            m_save.m_ingots = m_playersIngots;
            SaveGameManager.SaveCharacter(m_save);
        }
    }
}
