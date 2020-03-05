using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeChange : MonoBehaviour
{

    public Color eyeColour;
    public Color32 currentColour;
    public Texture currentTexture;
    public GameObject charEyes;

    void Update()
    {
        currentColour = this.GetComponent<Image>().color;
        currentTexture = this.GetComponent<Image>().mainTexture;

        //Debug.Log(currentColour.r + "" + currentColour.g + "" + currentColour.b);
    }

    public void ColourChange()
    {
        charEyes.GetComponent<Renderer>().material.color = currentColour;

        Debug.Log("Button Pressed: Colour " + currentColour);
    }

    public void ImageChange()
    {
        charEyes.GetComponent<Renderer>().material.SetTexture("_MainTex", currentTexture);

        Debug.Log("Button Pressed: Texture " + currentTexture.name);
    }
}
