//////////////////////////////////////////////////
/// File: TopChange.cs
/// Author: Kyle Tugwell
/// Date created: 05/03/2020
/// Last edit: 05/03/2020
/// Description: For the use of the character customiser's clothing.
/// Comments:
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopChange : MonoBehaviour
{
    public Color32 currentColour;
    public Texture currentTexture;
    public Material charTopMat;

    //Get the same textures which have been allocated to the right textures.
    void Update()
    {
        currentColour = this.GetComponent<Image>().color;
        currentTexture = this.GetComponent<Image>().mainTexture;
    }

    //Change the colour tint of the material.
    public void ColourChange()
    {
        charTopMat.SetColor("_Color", currentColour);
    }

    //Change the image of the material.
    public void PatternChange()
    {
        charTopMat.mainTexture = currentTexture;
    }
}
