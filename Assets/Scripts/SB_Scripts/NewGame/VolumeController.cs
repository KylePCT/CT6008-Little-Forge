//////////////////////////////////////////////////
/// File: VolumeController.cs
/// Author: Sam Baker
/// Date created: 27/05/2020
/// Last edit: 27/05/2020
/// Description: Used to control the volume of any no triggerable sounds.
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class VolumeController : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private AudioSource m_as;
    private float m_startVolume;
    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_as = gameObject.GetComponent<AudioSource>();
        m_startVolume = m_as.volume;
    }
    private void Update()
    {
        m_as.volume = m_startVolume * OptionsData.Instance.GetVolume();
    }
}
