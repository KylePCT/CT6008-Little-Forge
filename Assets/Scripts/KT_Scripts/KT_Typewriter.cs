//////////////////////////////////////////////////
/// File: KT_Typewriter.cs
/// Author: Kyle Tugwell/Sam Baker
/// Date created: 12/03/20
/// Last edit: 25/05/20
/// Description: Allow all interaction text to animate like a typewriter. 
/// Comments: Rewrote the script to make it work, but left in kyles work  -Sam Baker
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static NPCPatrol;

public class KT_Typewriter : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] TextMeshProUGUI tmpComponent;
    
    public float delay = 0.02f;
    public string fullText;
    private string currentText;
    private int characterIndex;
    private float m_timer;

    public GameObject[] Villagers;
    public AudioSource charAudioSource;
    public AudioClip[] charSounds;
    AudioClip charClip;

    NPCPatrol npcPatrol;

    public Voice voiceType;

    //////////////////////////////////////////////////
    //// Functions
    //void OnEnable()
    //{
    //    StartCoroutine(ShowText());
    //}

    //void Update()
    //{
    //    if (fullText != tmpComponent.text)
    //    {
    //        fullText = tmpComponent.text;
    //    }
    //}

    //IEnumerator ShowText()
    //{
    //    int characterIndex = 0;

    //    while(characterIndex++ != fullText.Length)
    //    {
    //        currentText = fullText.Substring(0, characterIndex);
    //        this.GetComponent<TextMeshProUGUI>().text = currentText;

    //        Debug.Log(characterIndex);

    //        yield return new WaitForSeconds(delay);
    //    }
    //}

    void OnEnable()
    {
        fullText = tmpComponent.text;
        characterIndex = 0;
        charAudioSource.GetComponent<AudioSource>();

        //Error in your code here kyle ???? maybe add a null check as the interact text can come up for other occasions not just the npc
        voiceType = npcPatrol.GetNPCVoiceType();
    }

    void Update()
    {
        if (currentText != fullText)
        {
            m_timer += Time.deltaTime;
            if (m_timer >= delay)
            {
                AddLetter();
                m_timer = 0; 
            }
        }

        tmpComponent.text = currentText;
    }

    private void AddLetter()
    {
        characterIndex++;
        currentText = fullText.Substring(0, characterIndex);

        charAudioSource.clip = charSounds[Random.Range(0, charSounds.Length)];
        charAudioSource.PlayOneShot(charAudioSource.clip);

        Debug.Log(voiceType);

        if (voiceType == Voice.Male)
        {
            charAudioSource.pitch = Random.Range(0.5f, 0.7f);
        }
        else if (voiceType == Voice.Female)
        {
            charAudioSource.pitch = Random.Range(1.1f, 1.4f);
        }
        else
        {
            charAudioSource.pitch = 1f;
        }
    }
}