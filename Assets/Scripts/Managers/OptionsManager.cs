//////////////////////////////////////////////////
// File: OptionsManager.cs
// Author: Zack Raeburn
// Date Created: 27/02/20
// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    private static OptionsManager m_instance = null;
    public static OptionsManager Instance
    {
        get { return m_instance; }
    }

    public class GameOptions
    {
        public float m_gameVolume = 0.5f;
        public float m_sensitivity = 0.5f;
    }

    private GameOptions m_options = null;
    public GameOptions Options
    {
        get { return m_options; }
    }

    //////////////////////////////////////////////////
    //// Functions

    public void SetOptions(GameOptions a_options)
    {
        m_options = a_options;
    }

}
