//////////////////////////////////////////////////
// File: LoadCharCustom.cs
// Author: Sam Baker
// Date Created: 03/05/20
// Description: Used to dress the player in the main hub scene using the saved customisations
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharCustom : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private SaveSlot m_mainSave = null;

    //Objects
    [SerializeField] private GameObject m_hair = null;
    [SerializeField] private GameObject m_headObject = null;
    [SerializeField] private GameObject m_lhandObject = null;
    [SerializeField] private GameObject m_rhandObject = null;
    [SerializeField] private GameObject m_leyeObject = null;
    [SerializeField] private GameObject m_reyeObject = null;
    [SerializeField] private GameObject m_noseObject = null;
    [SerializeField] private GameObject m_mouthObject = null;
    [SerializeField] private GameObject m_bodyObject = null;
    [SerializeField] private GameObject m_lshoeObject = null;
    [SerializeField] private GameObject m_rshoeObject = null;

    //Assets
    public Mesh[] m_allHairMeshes; //All meshes for hair
    public Texture[] m_allEyeTextures; //All textures for eyes
    public Texture[] m_allNoseTextures; //All textures for nose
    public Texture[] m_allMouthTextures; //All textures for mouth
    public Texture[] m_allBodyTopTextures; //All textures for bodytop
    public Texture[] m_allBodyBottomTextures; //All textures for bodybottom
    public Material[] m_allMaterials; //All materials for colour

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_mainSave = SaveGameManager.LoadCharacter(SaveGameManager.GetMainCharFile().m_saveSlotID);
        LoadHair();
        LoadSkin();
        LoadFace();
        LoadBody();
    }

    private void LoadBody()
    {
        //BodyTop Type
        for (int i = 0; i < m_allBodyTopTextures.Length; i++)
        {
            if (m_mainSave.m_bodyTopType == m_allBodyTopTextures[i].name)
            {
                m_bodyObject.GetComponent<Renderer>().materials[0].SetTexture("_MainTex", m_allBodyTopTextures[i]);
            }
        }
        //BodyTop Colour
        m_bodyObject.GetComponent<Renderer>().materials[0].color = new Color(m_mainSave.m_bodyTopColour[0], m_mainSave.m_bodyTopColour[1], m_mainSave.m_bodyTopColour[2]);

        //BodyBottom Type
        for (int i = 0; i < m_allBodyBottomTextures.Length; i++)
        {
            if (m_mainSave.m_bodyBottomType == m_allBodyBottomTextures[i].name)
            {
                m_bodyObject.GetComponent<Renderer>().materials[1].SetTexture("_MainTex", m_allBodyBottomTextures[i]);
            }
        }
        //BodyBottom Colour
        m_bodyObject.GetComponent<Renderer>().materials[1].color = new Color(m_mainSave.m_bodyBottomColour[0], m_mainSave.m_bodyBottomColour[1], m_mainSave.m_bodyBottomColour[2]);

        //Shoe Colour
        m_lshoeObject.GetComponent<Renderer>().material.color = new Color(m_mainSave.m_shoeColour[0], m_mainSave.m_shoeColour[1], m_mainSave.m_shoeColour[2]);
        m_rshoeObject.GetComponent<Renderer>().material.color = new Color(m_mainSave.m_shoeColour[0], m_mainSave.m_shoeColour[1], m_mainSave.m_shoeColour[2]);
    }

    private void LoadFace()
    {
        //Eyes Style
        for (int i = 0; i < m_allEyeTextures.Length; i++)
        {
            if (m_mainSave.m_eyeType == m_allEyeTextures[i].name)
            {
                m_leyeObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allEyeTextures[i]);
                m_reyeObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allEyeTextures[i]);
            }
        }
        //Eyes Colour
        m_leyeObject.GetComponent<Renderer>().material.color = new Color(m_mainSave.m_eyeColour[0], m_mainSave.m_eyeColour[1], m_mainSave.m_eyeColour[2]);
        m_reyeObject.GetComponent<Renderer>().material.color = new Color(m_mainSave.m_eyeColour[0], m_mainSave.m_eyeColour[1], m_mainSave.m_eyeColour[2]);

        //Nose Style
        for (int i = 0; i < m_allNoseTextures.Length; i++)
        {
            if (m_mainSave.m_noseType == m_allNoseTextures[i].name)
            {
                m_noseObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allNoseTextures[i]);
            }
        }

        //Mouth Style
        for (int i = 0; i < m_allMouthTextures.Length; i++)
        {
            if (m_mainSave.m_mouthType == m_allMouthTextures[i].name)
            {
                m_mouthObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allMouthTextures[i]);
            }
        }
    }

    private void LoadSkin()
    {
        //Skin Colour
        for (int i = 0; i < m_allMaterials.Length; i++)
        {
            if (m_mainSave.m_skinColour == (m_allMaterials[i].name + " (Instance)"))
            {
                m_headObject.GetComponent<MeshRenderer>().material = m_allMaterials[i];
                m_lhandObject.GetComponent<MeshRenderer>().material = m_allMaterials[i];
                m_rhandObject.GetComponent<MeshRenderer>().material = m_allMaterials[i];
            }
        }
    }

    private void LoadHair()
    {
        //Hair Style
        for (int i = 0; i < m_allHairMeshes.Length; i++)
        {
            if (m_mainSave.m_hairType == (m_allHairMeshes[i].name + " Instance"))
            {
                m_hair.GetComponent<MeshFilter>().mesh = m_allHairMeshes[i];
            }
        }
        //Hair Colour
        for (int i = 0; i < m_allMaterials.Length; i++)
        {
            if (m_mainSave.m_hairColour == (m_allMaterials[i].name + " (Instance)"))
            {
                m_hair.GetComponent<MeshRenderer>().material = m_allMaterials[i];
            }
        }
    }
}
