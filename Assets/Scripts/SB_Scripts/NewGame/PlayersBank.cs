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
    private static PlayersBank m_instance;
    public static PlayersBank Instance { get { return m_instance; } }

    //////////////////////////////////////////////////
    //// Functions
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
    /// <summary>
    /// Function inside the PlayersBank.cs, used to increase the amount of money in the players bank.
    /// </summary>
    /// <param name="a_money">Amount to add to the players bank</param>
    public void AddMoney(float a_money)
    {
        m_playersMoney += a_money;
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to decrease the amount of money in the players bank.
    /// </summary>
    /// <param name="a_money">Amount to takeaway from the players bank</param>
    public void TakeAwayMoney(float a_money)
    {
        if ((m_playersMoney - a_money) < 0)
        {
            Debug.LogWarning("Warning: Player does not have enough currency to purchase item!");
            return;
        }
        m_playersMoney -= a_money;
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to reset the amount of money in the players bank.
    /// </summary>
    public void ResetMoney()
    {
        m_playersMoney = 0;
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
    }
    /// <summary>
    /// Function inside the PlayersBank.cs, used to get the players current money.
    /// </summary>
    /// <returns>The int of the players currency is returned.</returns>
    public float GetMoney()
    {
        return m_playersMoney;
    }
}
