using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KT_UIAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public void playClick()
    {
        KT_AudioManager.instance.playSound("UIClick");
    }

    // Update is called once per frame
    public void playComplete()
    {
        KT_AudioManager.instance.playSound("UIComplete");
    }

    public void playHClick()
    {
        KT_AudioManager.instance.playSound("UIHigh");
    }
}
