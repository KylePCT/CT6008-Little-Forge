//////////////////////////////////////////////////
// File: CharacterSaver.cs
// Author: Sam Baker
// Date Created: 28/02/20
// Last Edit: 23/05/20 - Sam Baker
// Description: Saving the character file from the character creation scene
// Comments: Edited to save the customisations made to the character
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSaver : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private TMP_InputField m_name = null;
    public GameObject nameBox;

    //Objects for saving character customisation - Sam Baker
    [SerializeField] private GameObject m_headObject = null;
    [SerializeField] private GameObject m_hairObject = null;
    [SerializeField] private GameObject m_eyeObject = null;
    [SerializeField] private GameObject m_noseObject = null;
    [SerializeField] private GameObject m_mouthObject = null;
    [SerializeField] private GameObject m_bodyObject = null;
    [SerializeField] private GameObject m_shoeObject = null;

    //////////////////////////////////////////////////
    //// Functions

    /// <summary>
    /// Pack all character settings into the save file and load the game
    /// </summary>
    public void FinishCharacterCreation()
    {
        SaveSlot save = SaveGameManager.GetMainCharFile();
        save.m_name = m_name.text;
        save.m_money = 10f;
        //Sam Baker
        save.m_skinColour = m_headObject.GetComponent<MeshRenderer>().material.name;
        save.m_hairType = m_hairObject.GetComponent<MeshFilter>().mesh.name;
        save.m_hairColour = m_hairObject.GetComponent<MeshRenderer>().material.name;
        save.m_eyeType = m_eyeObject.GetComponent<Renderer>().material.GetTexture("_MainTex").name;
        save.m_eyeColour[0] = m_eyeObject.GetComponent<Renderer>().material.color.r;
        save.m_eyeColour[1] = m_eyeObject.GetComponent<Renderer>().material.color.g;
        save.m_eyeColour[2] = m_eyeObject.GetComponent<Renderer>().material.color.b;
        save.m_eyeType = m_eyeObject.GetComponent<Renderer>().material.GetTexture("_MainTex").name;
        save.m_noseType = m_noseObject.GetComponent<Renderer>().material.GetTexture("_MainTex").name;
        save.m_mouthType = m_mouthObject.GetComponent<Renderer>().material.GetTexture("_MainTex").name;
        save.m_bodyTopType = m_bodyObject.GetComponent<Renderer>().materials[0].GetTexture("_MainTex").name;
        save.m_bodyTopColour[0] = m_bodyObject.GetComponent<Renderer>().materials[0].color.r;
        save.m_bodyTopColour[1] = m_bodyObject.GetComponent<Renderer>().materials[0].color.g;
        save.m_bodyTopColour[2] = m_bodyObject.GetComponent<Renderer>().materials[0].color.b;
        save.m_bodyBottomType = m_bodyObject.GetComponent<Renderer>().materials[1].GetTexture("_MainTex").name;
        save.m_bodyBottomColour[0] = m_bodyObject.GetComponent<Renderer>().materials[1].color.r;
        save.m_bodyBottomColour[1] = m_bodyObject.GetComponent<Renderer>().materials[1].color.g;
        save.m_bodyBottomColour[2] = m_bodyObject.GetComponent<Renderer>().materials[1].color.b;
        save.m_shoeColour[0] = m_shoeObject.GetComponent<Renderer>().material.color.r;
        save.m_shoeColour[1] = m_shoeObject.GetComponent<Renderer>().material.color.g;
        save.m_shoeColour[2] = m_shoeObject.GetComponent<Renderer>().material.color.b;
        save.m_tutComplete = 0;
        save.m_money = 0;
        save.m_ingots = 0;
        save.m_level = 0;
        save.m_xp = 0;
        save.m_questsComplete = 0;

        for (int i = 0; i < save.m_forgeItems.Length; i++)
        {
            save.m_forgeItems[i] = 0;
        }
        LoadSecret(save);

        //Kyle Tugwell
        if(m_name.text == "")
        {
            nameBox.SetActive(true);
            Debug.Log("No name specified. User must enter a name.");
        }

        else
        {
            SaveGameManager.SaveCharacter(save);

            // Load default scenes
            SceneLoadManager.Instance.LoadScenesLoadingScreen(3);
        }
    }

    private void LoadSecret(SaveSlot a_save)
    {
        if (a_save.m_name == "SAMISTHEBEST")
        {
            a_save.m_tutComplete = 1;
            a_save.m_money = 1200000000;
            a_save.m_ingots = 9999999;
            a_save.m_level = 10;
        }
    }
}
