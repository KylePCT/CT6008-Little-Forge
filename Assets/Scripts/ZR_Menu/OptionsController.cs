//////////////////////////////////////////////////
/// File: OptionsController.cs
/// Author: Zack Raeburn
/// Date Created: 27/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] private Slider m_audioVolume = null;
    [SerializeField] private Slider m_sensitivity = null;

    private void Start()
    {
        float audioVolume;
        float sensitivity;
        SaveGameManager.GetOptions(out audioVolume, out sensitivity);
        m_audioVolume.value = audioVolume;
        m_sensitivity.value = sensitivity;
    }

    public void SaveOptions()
    {
        SaveGameManager.SetOptions(m_audioVolume.value, m_sensitivity.value);
    }

    private void OnDisable()
    {
        SaveGameManager.SaveHeader();
    }
}
