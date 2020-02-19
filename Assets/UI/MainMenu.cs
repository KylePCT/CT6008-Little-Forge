using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Kyle Tugwell
//19/02/20 22:14

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Play button pressed. Opening Main Scene.");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit button pressed. Closing application.");
    }

    public Slider volumeSlider;
    public AudioSource volumeAudio;

    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
        Debug.Log("Volume changed to " + volumeSlider.value + ".");
    }
}
