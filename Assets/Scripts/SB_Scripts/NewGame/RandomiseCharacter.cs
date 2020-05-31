//////////////////////////////////////////////////
// File: RandomiseCharacter.cs
// Author: Sam Baker
// Date Created: 05/05/20
// Description: Script used to call a function that randomises the player customisation
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomiseCharacter : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] private GameObject m_headObject = null;
    [SerializeField] private GameObject m_lhandObject = null;
    [SerializeField] private GameObject m_rhandObject = null;
    [SerializeField] private GameObject m_hairObject = null;
    [SerializeField] private GameObject m_leyeObject = null;
    [SerializeField] private GameObject m_reyeObject = null;
    [SerializeField] private GameObject m_noseObject = null;
    [SerializeField] private GameObject m_mouthObject = null;
    [SerializeField] private GameObject m_bodyObject = null;
    [SerializeField] private GameObject m_lshoeObject = null;
    [SerializeField] private GameObject m_rshoeObject = null;

    public Mesh[] m_allHairMeshes; //All meshes for hair
    public Texture[] m_allEyeTextures; //All textures for eyes
    public Texture[] m_allNoseTextures; //All textures for nose
    public Texture[] m_allMouthTextures; //All textures for mouth
    public Texture[] m_allBodyTopTextures; //All textures for bodytop
    public Texture[] m_allBodyBottomTextures; //All textures for bodybottom
    public GameObject[] m_allSkinMaterials; //All materials for skin colour
    public GameObject[] m_allHairMaterials; //All materials for hair colour
    public GameObject[] m_allEyeMaterials; //All materials for eye colour
    public GameObject[] m_allBodyMaterials; //All materials for body colour
    public GameObject[] m_allShoeMaterials; //All materials for shoe colour

    //////////////////////////////////////////////////
    //// Functions
    public void Randomise()
    {
        //Skin Colour
        int rand = UnityEngine.Random.Range(0, m_allSkinMaterials.Length);
        m_headObject.GetComponent<MeshRenderer>().material = m_allSkinMaterials[rand].GetComponent<MaterialHolder>().GetMat();
        m_lhandObject.GetComponent<MeshRenderer>().material = m_allSkinMaterials[rand].GetComponent<MaterialHolder>().GetMat();
        m_rhandObject.GetComponent<MeshRenderer>().material = m_allSkinMaterials[rand].GetComponent<MaterialHolder>().GetMat();

        //Hair Type and Colour
 
        int rand1 = UnityEngine.Random.Range(0, m_allHairMeshes.Length);
        m_hairObject.GetComponent<MeshFilter>().mesh = m_allHairMeshes[rand1];

        int rand2 = UnityEngine.Random.Range(0, m_allHairMaterials.Length);
        m_hairObject.GetComponent<MeshRenderer>().material = m_allHairMaterials[rand2].GetComponent<MaterialHolder>().GetMat();

        //Eyes Type and Colour
        int rand3 = UnityEngine.Random.Range(0, m_allEyeTextures.Length);
        m_leyeObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allEyeTextures[rand3]);
        m_reyeObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allEyeTextures[rand3]);

        int rand4 = UnityEngine.Random.Range(0, m_allEyeMaterials.Length);
        m_leyeObject.GetComponent<Renderer>().material.color = m_allEyeMaterials[rand4].GetComponent<Image>().color;
        m_reyeObject.GetComponent<Renderer>().material.color = m_allEyeMaterials[rand4].GetComponent<Image>().color;

        //Nose Type
        int rand5 = UnityEngine.Random.Range(0, m_allNoseTextures.Length);
        m_noseObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allNoseTextures[rand5]);

        //Mouth Type
        int rand6 = UnityEngine.Random.Range(0, m_allMouthTextures.Length);
        m_mouthObject.GetComponent<Renderer>().material.SetTexture("_MainTex", m_allMouthTextures[rand6]);

        //Body Type and Colour
        //All elements changed to sharedMaterials to stop bug of randomisation stopping customisation working - KT 31/05
        int rand7 = UnityEngine.Random.Range(0, m_allBodyTopTextures.Length);
        m_bodyObject.GetComponent<Renderer>().sharedMaterials[0].SetTexture("_MainTex", m_allBodyTopTextures[rand7]);

        int rand8 = UnityEngine.Random.Range(0, m_allBodyBottomTextures.Length);
        m_bodyObject.GetComponent<Renderer>().sharedMaterials[1].SetTexture("_MainTex", m_allBodyBottomTextures[rand8]);

        int rand9 = UnityEngine.Random.Range(0, m_allBodyMaterials.Length);
        m_bodyObject.GetComponent<Renderer>().sharedMaterials[0].color = m_allBodyMaterials[rand9].GetComponent<Image>().color;

        int rand10 = UnityEngine.Random.Range(0, m_allBodyMaterials.Length);
        m_bodyObject.GetComponent<Renderer>().sharedMaterials[1].color = m_allBodyMaterials[rand10].GetComponent<Image>().color;

        //Shoe Colour
        int rand11 = UnityEngine.Random.Range(0, m_allShoeMaterials.Length);
        m_lshoeObject.GetComponent<Renderer>().material.color = m_allShoeMaterials[rand11].GetComponent<Image>().color;
        m_rshoeObject.GetComponent<Renderer>().material.color = m_allShoeMaterials[rand11].GetComponent<Image>().color;
    }
}
