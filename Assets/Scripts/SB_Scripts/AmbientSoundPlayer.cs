//////////////////////////////////////////////////
/// File: AmbientSoundPlayer.cs
/// Author: Sam Baker
/// Date created: 19/02/20
/// Last edit: 19/02/20
/// Description: Used to play ambient sound around the map in 3D space. Allows for multiple sounds
///             and changes the pitch slightly so they dont sound repetative.
/// Comments:
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundPlayer : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private AudioSource audioSource;
    private float timer;

    public AudioClip[] sounds;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timer = Random.Range(2.0f, 6.0f);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            audioSource.clip = sounds[Random.Range(0, sounds.Length)];
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            audioSource.Play();
            timer = Random.Range(2.0f, 6.0f);
        }
    }
}
