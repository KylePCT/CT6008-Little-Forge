//////////////////////////////////////////////////
// File: FurniturePanel.cs
// Author: Sam Baker
// Date Created: 06/05/20
// Last Edit:
// Description: Script for the furniture panel
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurniturePanel : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private SimpleFurniture m_whereToPlace = null;
    [Tooltip ("Place items in order of the menu")]
    public GameObject[] m_items = null;

    //////////////////////////////////////////////////
    //// Functions
    
    public void WhoOpenedPanel(SimpleFurniture a_simpleFurniture)
    {
        m_whereToPlace = a_simpleFurniture;
    }

    public void Item1()
    {
        if (m_items[0] != null)
        {
            m_whereToPlace.PlaceFurniture(m_items[0]);
        }
        else
        {
            Debug.LogWarning("Check gameobject in the m_items array on the FurniturePanel script");
        }
    }
    public void Item2()
    {
        if (m_items[1] != null)
        {
            m_whereToPlace.PlaceFurniture(m_items[1]);
        }
        else
        {
            Debug.LogWarning("Check gameobject in the m_items array on the FurniturePanel script");
        }
    }
    public void Item3()
    {
        if (m_items[2] != null)
        {
            m_whereToPlace.PlaceFurniture(m_items[2]);
        }
        else
        {
            Debug.LogWarning("Check gameobject in the m_items array on the FurniturePanel script");
        }
    }
    public void Item4()
    {
        if (m_items[3] != null)
        {
            m_whereToPlace.PlaceFurniture(m_items[3]);
        }
        else
        {
            Debug.LogWarning("Check gameobject in the m_items array on the FurniturePanel script");
        }
    }
    public void Item5()
    {
        if (m_items[4] != null)
        {
            m_whereToPlace.PlaceFurniture(m_items[4]);
        }
        else
        {
            Debug.LogWarning("Check gameobject in the m_items array on the FurniturePanel script");
        }
    }
}
