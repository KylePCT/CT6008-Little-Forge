//////////////////////////////////////////////////
/// File: AmbientSoundPlayer.cs
/// Author: Sam Baker
/// Date created: 19/02/20
/// Last edit: 19/02/20
/// Description: Used to play ambient sound around the map in 3D space. Allows for multiple sounds
///             and changes the pitch slightly so they dont sound repetative.
/// Comments:
//////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundPlayer : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private AudioSource m_audioSource;
    private float m_timer;

    public AudioClip[] m_sounds;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_timer = UnityEngine.Random.Range(2.0f, 6.0f);
    }

    private void Update()
    {
        UpdateSound();
    }

    private void UpdateSound()
    {
        m_timer -= Time.deltaTime;
        if (m_timer <= 0)
        {
            m_audioSource.clip = m_sounds[UnityEngine.Random.Range(0, m_sounds.Length)];
            m_audioSource.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
            m_audioSource.Play();
            m_timer = UnityEngine.Random.Range(2.0f, 6.0f);
        }
    }
}
