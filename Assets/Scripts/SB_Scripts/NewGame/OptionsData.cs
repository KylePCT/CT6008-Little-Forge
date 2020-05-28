//////////////////////////////////////////////////
/// File: OptionsData.cs
/// Author: Sam Baker
/// Date created: 27/05/2020
/// Last edit: 27/05/2020
/// Description: Script singleton to hold and carry the data for the options.
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsData : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private float m_gameVoulume = 0.75f;
    private float m_gameSensitivity = 0.2f;

    //////////////////////////////////////////////////
    //// Functions
    private static OptionsData instance = null;

    public static OptionsData Instance {
        get {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        float audioVolume;
        float sensitivity;
        SaveGameManager.GetOptions(out audioVolume, out sensitivity);
        m_gameVoulume = audioVolume;
        m_gameSensitivity = sensitivity;
    }

    public void SetVolume(float a_value) => m_gameVoulume = a_value;

    public void SetSensitivity(float a_value) => m_gameSensitivity = a_value;

    public float GetVolume() => m_gameVoulume;

    public float GetSensitivity() => m_gameSensitivity;
}
