//////////////////////////////////////////////////
/// File: NoseChange.cs
/// Author: Kyle Tugwell
/// Date created: 05/03/2020
/// Last edit: 05/03/2020
/// Description: For the use of the character customiser's nose segment.
/// Comments:
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouthChange : MonoBehaviour
{
    public Texture currentTexture;
    public GameObject charMouth;

    //Get the same textures which have been allocated to the right textures.
    void Update()
    {
        currentTexture = this.GetComponent<Image>().mainTexture;

        //Debug.Log(currentColour.r + "" + currentColour.g + "" + currentColour.b);
    }

    //Change the image of the material.
    public void ImageChange()
    {
        charMouth.GetComponent<Renderer>().material.SetTexture("_MainTex", currentTexture);

        Debug.Log("Button Pressed: Texture " + currentTexture.name);
    }
}
