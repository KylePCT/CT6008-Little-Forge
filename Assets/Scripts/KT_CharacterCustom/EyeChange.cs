//////////////////////////////////////////////////
/// File: EyeChange.cs
/// Author: Kyle Tugwell
/// Date created: 05/03/2020
/// Last edit: 05/03/2020
/// Description: For the use of the character customiser's eye segment.
/// Comments:
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeChange : MonoBehaviour
{
    public Color32 currentColour;
    public Texture currentTexture;
    public GameObject charEyes;
    public GameObject charEyes2;

    //Get the same textures which have been allocated to the right textures.
    void Update()
    {
        currentColour = this.GetComponent<Image>().color;
        currentTexture = this.GetComponent<Image>().mainTexture;


        //Debug.Log(currentColour.r + "" + currentColour.g + "" + currentColour.b);
    }

    //Change the colour tint of the material.
    public void ColourChange()
    {
        charEyes.GetComponent<Renderer>().material.color = currentColour;
        charEyes2.GetComponent<Renderer>().material.color = currentColour;

        Debug.Log("Button Pressed: Colour " + currentColour);
    }

    //Change the image of the material.
    public void ImageChange()
    {
        charEyes.GetComponent<Renderer>().material.SetTexture("_MainTex", currentTexture);
        charEyes2.GetComponent<Renderer>().material.SetTexture("_MainTex", currentTexture);

        Debug.Log("Button Pressed: Texture " + currentTexture.name);
    }
}
