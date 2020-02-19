//Sam Baker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private float timer;

    public AudioClip[] sounds;

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
