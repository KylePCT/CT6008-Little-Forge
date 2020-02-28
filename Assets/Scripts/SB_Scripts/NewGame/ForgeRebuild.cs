//////////////////////////////////////////////////
/// File: ForgeRebuild.cs
/// Author: Sam Baker
/// Date created: 28/02/20
/// Last edit: 28/02/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeRebuild : MonoBehaviour
{
    [Header("_____________________________________________________")]
    [Space(-20)]
    [Header(" > Forge generate currency based on level.")]
    [Space(-10)]
    [Header(" > Walk up to forge and interact with E.")]
    [Space(-10)]
    [Header(" > Forge level in the top right.")]
    [Space(-10)]
    [Header("Forge Rebuild")]
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Mesh[] m_levelsOfMesh = new Mesh[0];
    private int m_forgeLevel = 0;
    private int m_currentCost = 0;
    private bool m_upgrade = false;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        PlayersBank.Instance.SetMoney(100);
    }
    private void Update()
    {
        Debug.Log(m_forgeLevel);
        switch(m_forgeLevel)
        {
            case 0:
                BrokenForge();
                break;
            case 1:
                Level1Forge();
                break;
            case 2:
                Level2Forge();
                break;
            case 3:
                Level3Forge();
                break;
            case 4:
                Level4Forge();
                break;
            case 5:
                Level5Forge();
                break;
            default:
                break;
        }
        m_upgrade = false;
    }

    private void BrokenForge()
    {
        //Cost to rebuild : 10
        m_currentCost = 10;
        if(m_upgrade)
        {
            CheckToBuy();
        }
    }


    private void Level1Forge()
    {
        //Cost to upgrade : 30
        m_currentCost = 30;
        if (m_upgrade)
        {
            CheckToBuy();
        }
    }
    private void Level2Forge()
    {
        //Cost to upgrade : 90
        m_currentCost = 90;
    }
    private void Level3Forge()
    {
        //Cost to upgrade : 270
        m_currentCost = 270;
    }
    private void Level4Forge()
    {
        //Cost to upgrade : 810
        m_currentCost = 810;
    }
    private void Level5Forge()
    {
        //Max Level
    }

    private void CheckToBuy()
    {
        if (PlayersBank.Instance.GetMoney() >= m_currentCost)
        {
            //Has Enough
            PlayersBank.Instance.TakeAwayMoney(m_currentCost);
            m_forgeLevel++;
        }
        else
        {
            //Not enough 
        }
        m_upgrade = false;
    }

    private void OnTriggerStay(Collider col)
    {
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                m_upgrade = true;
            }
        }
    }

    public int GetForgeLevel() 
    {
        return m_forgeLevel;
    }
}
