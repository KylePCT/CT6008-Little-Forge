using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class KT_AudioManager : MonoBehaviour
{
    public KT_Sound[] Sounds;

    public static KT_AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        foreach(KT_Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = OptionsData.Instance.GetVolume();
            s.source.pitch = s.pitch;
            s.source.playOnAwake = s.playOnAwake;
            s.source.loop = s.loop;
        }
    }

    public void playSound (string name)
    {
        KT_Sound s = Array.Find(Sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log(s + " does not currently exist. Is there a typo?");
            return;
        }
        s.source.volume = OptionsData.Instance.GetVolume();
        s.source.Play();
    }

    public void stopSound (string name)
    {
        KT_Sound s = Array.Find(Sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log(s + " does not currently exist. Is there a typo?");
            return;
        }

        s.source.Stop();
    }
}
