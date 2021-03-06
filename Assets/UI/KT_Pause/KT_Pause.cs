﻿//////////////////////////////////////////////////
/// File: KT_Pause.cs
/// Author: Kyle Tugwell
/// Date created: 19/03/20
/// Last edit: 19/04/20 - sam
/// Description: A script to manage pausing and the menu's animations.
/// Comments: Fading code attained from User: MichaelHouse at https://gamedev.stackexchange.com/questions/123938/unity-i-want-to-make-my-ui-text-fade-in-after-5-seconds on 19/03/2020 13:19; everything else is written by me
///             Implementation of inventory - sam
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KT_Pause : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    public bool isPaused = false;
    public GameObject pauseCanvas;
    public GameObject mainCanvas;
    [SerializeField] private GameObject m_invCanvas = null;
    [SerializeField] private GameObject m_optCanvas = null;
    [SerializeField] private GameObject m_toolTip = null;

    //each menu wedge
    public GameObject wedge_1;
    public GameObject wedge_2;
    public GameObject wedge_3;

    //cG is for alphas
    public CanvasGroup canvasGroup;

    //fade for alpha
    public float fadeInDelay;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject playerOrientation;
    [SerializeField]
    private GameObject weapon;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        //make sure all tweens are scaled to 0 and alphas are 0 for the pause menu
        LeanTween.scale(wedge_1, new Vector3(0, 0, 0), 0f);
        LeanTween.scale(wedge_2, new Vector3(0, 0, 0), 0f);
        LeanTween.scale(wedge_3, new Vector3(0, 0, 0), 0f);

        canvasGroup.alpha = 0;

        m_invCanvas.SetActive(false);
        m_optCanvas.SetActive(false);
    }
    void Update()
    {
        //Quick trigger to cause the UI to close - SB
        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            player.GetComponent<PlayerControls>().OnEnable();
            playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
            weapon.GetComponent<FiringWeapon>().SetWeaponActive(true);
            player.GetComponent<PlayerZoom>().enabled = true;


            LeanTween.scale(wedge_1, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
            LeanTween.scale(wedge_2, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
            LeanTween.scale(wedge_3, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);

            m_invCanvas.SetActive(false);
            m_optCanvas.SetActive(false);
            m_toolTip.SetActive(false);

            FadeOut();
        }
        //if 'Esc' or button 'Cancel' is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isPaused == false)
            {
                //show cursor, swap canvases
                isPaused = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                pauseCanvas.SetActive(true);
                mainCanvas.SetActive(false);

                //stop inputs
                player.GetComponent<PlayerControls>().OnDisable();
                playerOrientation.GetComponent<PlayerOrientation>().OnDisable();
                weapon.GetComponent<FiringWeapon>().SetWeaponActive(false);
                player.GetComponent<PlayerZoom>().enabled = false;

                //have wedges zoom in
                LeanTween.scale(wedge_1, new Vector3(1, 1, 1), 0.2f);
                LeanTween.scale(wedge_2, new Vector3(1, 1, 1), 0.2f);
                LeanTween.scale(wedge_3, new Vector3(1, 1, 1), 0.2f);

                //fade
                FadeIn();
            }

            else
            {
                //if it's already paused, do the opposite
                isPaused = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                player.GetComponent<PlayerControls>().OnEnable();
                playerOrientation.GetComponent<PlayerOrientation>().OnEnable();
                weapon.GetComponent<FiringWeapon>().SetWeaponActive(true);
                player.GetComponent<PlayerZoom>().enabled = true;


                LeanTween.scale(wedge_1, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
                LeanTween.scale(wedge_2, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
                LeanTween.scale(wedge_3, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);

                m_invCanvas.SetActive(false);
                m_optCanvas.SetActive(false);
                m_toolTip.SetActive(false);

                FadeOut();
            }
        }
    }

    public void mainCanvHidden()
    {
        pauseCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    //this function is repeated for buttons to be able to call it
    public void closePause()
    {
        isPaused = false;
        Cursor.visible = false;
        player.GetComponent<PlayerZoom>().enabled = true;


        player.GetComponent<PlayerControls>().OnEnable();

        LeanTween.scale(wedge_1, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
        LeanTween.scale(wedge_2, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);
        LeanTween.scale(wedge_3, new Vector3(0, 0, 0), 0.2f).setOnComplete(mainCanvHidden);

        FadeOut();
    }

    //Fading code attained from User: MichaelHouse at https://gamedev.stackexchange.com/questions/123938/unity-i-want-to-make-my-ui-text-fade-in-after-5-seconds on 19/03/2020 13:19

    //////////////////////////////////////////////////
    //// Variables
    public float changeTimeSeconds = 5;
    public float startAlpha = 0;
    public float endAlpha = 1;

    float changeRate = 0;
    float timeSoFar = 0;
    bool fading = false;

    //////////////////////////////////////////////////
    //// Functions
    public void FadeIn()
    {
        startAlpha = 0;
        endAlpha = 1;
        timeSoFar = 0;
        fading = true;
        StartCoroutine(FadeCoroutine());
    }

    public void FadeOut()
    {
        startAlpha = 1;
        endAlpha = 0;
        timeSoFar = 0;
        fading = true;
        StartCoroutine(FadeCoroutine());
    }

    //runs the fade
    IEnumerator FadeCoroutine()
    {
        changeRate = (endAlpha - startAlpha) / changeTimeSeconds;
        SetAlpha(startAlpha);
        while (fading)
        {
            timeSoFar += Time.deltaTime;

            if (timeSoFar > changeTimeSeconds)
            {
                fading = false;
                SetAlpha(endAlpha);
                yield break;
            }
            else
            {
                SetAlpha(canvasGroup.alpha + (changeRate * Time.deltaTime));
            }

            yield return null;
        }
    }

    //sets alpha for the group
    public void SetAlpha(float alpha)
    {
        canvasGroup.alpha = Mathf.Clamp(alpha, 0, 1);
    }
}
