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
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private Mesh[] m_levelsOfMesh = new Mesh[0];
    private int m_forgeLevel = 0;
    private int m_currentCost = 0;

    //////////////////////////////////////////////////
    //// Functions
    private void Update()
    {
        switch(m_forgeLevel)
        {
            case 0:
                BrokenForge();
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
    }

    private void BrokenForge()
    {
        throw new NotImplementedException();
    }
    private void Level1Forge()
    {
        throw new NotImplementedException();
    }
    private void Level2Forge()
    {
        throw new NotImplementedException();
    }
    private void Level3Forge()
    {
        throw new NotImplementedException();
    }
    private void Level4Forge()
    {
        throw new NotImplementedException();
    }
    private void Level5Forge()
    {
        throw new NotImplementedException();
    }
}
