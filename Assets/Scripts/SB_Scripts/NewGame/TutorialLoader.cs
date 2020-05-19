//////////////////////////////////////////////////
// File: TutorialLoader.cs
// Author: Sam Baker/Kyle Tugwell
// Date Created: 17/05/20
// Last Edit: 19/05
// Description: Script used to start the tutorial cinematic
// Comments: 
// + Tutorial NPC functionality
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class TutorialLoader : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private bool m_tutorialCalled = false;

    //KT v
    public GameObject interactText;
    [SerializeField] private TextMeshProUGUI tutText = null;

    public string[] sentences;
    [SerializeField] Emotion[] textEmotions;

    private int index;
    public float textSpeed;

    public Animator NPCAnimator;

    public GameObject continueText;

    //////////////////////////////////////////////////
    //// Functions

    private void Update()
    {
        if (tutText.text == sentences[index])
        {
            continueText.SetActive(true);
        }

        if (Input.anyKeyDown)
        {
            NextSentence();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (!m_tutorialCalled)
        {
            if (col.gameObject.tag == "Player")
            {
                m_tutorialCalled = true;
                interactText.SetActive(true);
                LoadTutCinematic();
            }
        }
    }

    //KT v
    private void LoadTutCinematic()
    {
        Debug.Log("***THIS IS WHERE THE TUTORIAL CINEMATIC SHOULD TRIGGER*** ***DOUBLE CLICK TO GO TO CODE***");

        StartCoroutine(Type());
        DisplayEmotion();

        //psuedo code
        //talk - introduction
        //change emotion
        //text on button press - who are you
        //oh youre "name"
        //welcome to island
        //what do you do here?
        //show each place
        //tut is done
        //npc vanishes with vfx
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            tutText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    enum Emotion
    {
        Idle,
        Happy,
        Concerned,
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            tutText.text = "";
            StartCoroutine(Type());
            DisplayEmotion();
            continueText.SetActive(false);
        }
        else
        {
            tutText.text = "";
            continueText.SetActive(false);
        }
    }

    public void DisplayEmotion()
    {
        string Emotion = textEmotions[index].ToString();

        Debug.Log("Playing animation: " + Emotion + ".");

        if (Emotion == "Idle")
        {
            NPCAnimator.SetBool("isHappy", false);
            NPCAnimator.SetBool("isConcerned", false);
        }
        else if (Emotion == "Happy")
        {
            NPCAnimator.SetBool("isHappy", true);
            NPCAnimator.SetBool("isConcerned", false);
        }
        else if (Emotion == "Concerned")
        {
            NPCAnimator.SetBool("isHappy", false);
            NPCAnimator.SetBool("isConcerned", true);
        }
    }
}
