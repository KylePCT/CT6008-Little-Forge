﻿//////////////////////////////////////////////////
/// File: OptionsController.cs
/// Author: Zack Raeburn
/// Date Created: 27/02/20
/// Description: Allows for controlling and saving options
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private Slider m_audioVolume = null;
    [SerializeField] private Slider m_sensitivity = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        // Getting currently saved options from the game save file
        float audioVolume;
        float sensitivity;
        SaveGameManager.GetOptions(out audioVolume, out sensitivity);

        // Setting the UI to the saved options
        m_audioVolume.value = audioVolume;
        m_sensitivity.value = sensitivity;
    }

    public void SaveOptions()
    {
        SaveGameManager.SetOptions(m_audioVolume.value, m_sensitivity.value);
    }

    private void OnDestroy()
    {
        SaveGameManager.SaveHeader();
    }
}
