//////////////////////////////////////////////////
// File: TutorialLoader.cs
// Author: Sam Baker/Kyle Tugwell
// Date Created: 17/05/20
// Last Edit: 21/05
// Description: Script used to start the tutorial cinematic
// Comments: 
// (Kyle)
// + Tutorial NPC functionality
// + NPC emotions
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
    //SB
    private bool m_tutorialCalled = false;

    //KT
    [Header("Player Parameters")]
    //These variables just allow us to disable all interaction.
    public GameObject player;
    public GameObject playerOrientation;
    public GameObject weapon;

    //Camera settings
    public GameObject playerCamera;
    private Vector3 origPos = Vector3.zero;
    private Quaternion origRot = Quaternion.Euler(0, 0, 0);
    public float camDistance = 5.0f;

    //This designates UI elements such as the text GameObjects and Animators
    [Header("UI Parameters")]
    public GameObject interactText;
    [SerializeField] private TextMeshProUGUI tutText = null;

    private int index;
    public float textSpeed;
    private bool isTalking;

    public Animator NPCAnimator;

    public GameObject continueTextUI;

    public bool tutorialComplete = false;

    //These are the arrays a user is able to customise to create mini-cutscenes; the elements sync between each array
    [Header("Index Arrays - the numbers must match up.")]
    public string[] sentences;
    [SerializeField] Emotion[] textEmotions;
    public Transform[] cameraTarget;

    //////////////////////////////////////////////////
    //// Functions

    //KT
    private void Start()
    {
        //Store camera locals
        origPos = playerCamera.transform.localPosition;

        //Stop inputs
        player.GetComponent<PlayerControls>().OnDisable();
        playerOrientation.GetComponent<PlayerOrientation>().OnDisable();
        weapon.GetComponent<FiringWeapon>().SetWeaponActive(false);
        player.GetComponent<PlayerZoom>().enabled = false;
    }
    private void Update()
    {
        //if the text has reached the sentence length
        if (tutText.text == sentences[index])
        {
            isTalking = false;
        }

        //if any key is pressed, move on to the next sentence
        if (Input.anyKeyDown && isTalking == false)
        {
            NextSentence();
            isTalking = true;
        }

        //show the continue UI dependant on speech
        if (isTalking == true)
        {
            continueTextUI.SetActive(false);
        }

        else
        {
            continueTextUI.SetActive(true);
        }
    }

    //SB
    private void OnTriggerEnter(Collider col)
    {
        if (!m_tutorialCalled && tutorialComplete == false)
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
        //Starts the text coroutine, and plays the stated emotion and camera movement dependant on the array element
        StartCoroutine(Type());
        DisplayEmotion();
        MoveCamera();
    }

    //typewriter effect
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            tutText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //Enum for the emotions available on the animations
    enum Emotion
    {
        Idle,
        Happy,
        Concerned,
    }

    //Sentence elements for the NPC interaction dependant on what has been stated in the GUI for sentences
    public void NextSentence()
    {
        isTalking = true;

        //if there are more sentences, continue calling the classes for interaction
        if (index < sentences.Length - 1)
        {
            index++;
            tutText.text = "";
            StartCoroutine(Type());
            DisplayEmotion();
            MoveCamera();
            isTalking = true;
            continueTextUI.SetActive(false);
        }

        //if all interaction is complete, reset ui, player controls and camera transform
        else
        {
            //if the tutorial is complete
            if (tutorialComplete == false)
            {
                //set it to true and allow interaction to be used again
                tutorialComplete = true;
                tutText.text = "";
                continueTextUI.SetActive(false);
                interactText.SetActive(false);

                //reset camera
                playerCamera.transform.localPosition = origPos;
                playerCamera.transform.rotation = Quaternion.Euler(0, 0, 0);

                player.GetComponent<PlayerControls>().OnEnable();
                playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
                weapon.GetComponent<FiringWeapon>().SetWeaponActive(true);
                player.GetComponent<PlayerZoom>().enabled = true;

                gameObject.SetActive(false);

                Debug.Log("Tutorial Completed.");
            }
        }
    }

    //Changes the animation variables dependant on the selected emotion and plays said animation
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

    //Moves the camera to the object which has been selected in the array
    public void MoveCamera()
    {
        if (tutorialComplete == false)
        {
            playerCamera.transform.position = new Vector3(cameraTarget[index].position.x, cameraTarget[index].position.y, cameraTarget[index].position.z);
            playerCamera.transform.rotation = cameraTarget[index].rotation;
        }

        else
        {
            playerCamera.transform.position = origPos;
            playerCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
