//////////////////////////////////////////////////
// File: ShockwaveManager.cs
// Author: Zack Raeburn
// Date Created: 23/01/20
// Description: Allows the animating of shockwave variables
//              and sends them to the shader
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockwaveManager : MonoBehaviour
{
    private int m_shockSizeID = 0;
    private int m_shockThicknessID = 0;
    private int m_shockStrengthID = 0;

    [SerializeField] private float m_targetShockSize = 500f;
    [SerializeField] private float m_shockSizeSpeed = 2000f;
    [SerializeField] private float m_targetShockStrength = 1f;
    [SerializeField] private float m_shockStrengthSpeed = 10f;

    [SerializeField] private Transform m_shockwavePos = null;

    private IEnumerator m_currentCoroutine = null;
    private Material m_shockwaveMat = null;

    private void Awake()
    {
        InitialiseVariables();
    }

    /// <summary>
    /// Variable initialisation
    /// </summary>
    private void InitialiseVariables()
    {
        m_shockSizeID = Shader.PropertyToID("_ShockSize");
        m_shockThicknessID = Shader.PropertyToID("_ShockThickness");
        m_shockStrengthID = Shader.PropertyToID("_ShockStrength");

        FullScreenEffects.OnConstructMaterials += OnConstructMaterials;
    }

    /// <summary>
    /// We are using a material from the FullScreenEffect script, when the material list is regenerated we need to find the shockwave shader in it
    /// </summary>
    /// <param name="a_sender"></param>
    private void OnConstructMaterials(FullScreenEffects a_sender)
    {
        for (int i = 0; i < a_sender.Materials.Count; ++i)
        {
            if (a_sender.Materials[i].shader.name == "Hidden/Shockwave")
            {
                m_shockwaveMat = a_sender.Materials[i];
                return;
            }
        }
    }

    /// <summary>
    /// Sends a shockwave to the shader
    /// </summary>
    public void CreateShockwave()
    {
        if (m_shockwaveMat == null)
            return;

        if (m_currentCoroutine != null)
            StopCoroutine(m_currentCoroutine);

        m_currentCoroutine = ShockwaveIE();
        StartCoroutine(m_currentCoroutine);
    }

    /// <summary>
    /// Sends a shockwave to the shader
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShockwaveIE()
    {
        // Getting current values
        float shockSize = m_shockwaveMat.GetFloat(m_shockSizeID);
        float shockStrength = m_shockwaveMat.GetFloat(m_shockStrengthID);

        // Setting the world position of the shockwave
        m_shockwaveMat.SetVector("_WorldPos", m_shockwavePos.position);

        // Wait one frame
        yield return null;

        // Animate the shockwave values
        while (shockSize != m_targetShockSize || shockStrength != m_targetShockStrength)
        {
            shockSize = Mathf.MoveTowards(shockSize, m_targetShockSize, Time.deltaTime * m_shockSizeSpeed);
            shockStrength = Mathf.MoveTowards(shockStrength, m_targetShockStrength, Time.deltaTime * m_shockStrengthSpeed);

            m_shockwaveMat.SetFloat(m_shockSizeID, shockSize);
            m_shockwaveMat.SetFloat(m_shockStrengthID, shockStrength);

            yield return null;
        }

        // Clear the shockwave
        m_shockwaveMat.SetFloat(m_shockSizeID, 0f);
        m_shockwaveMat.SetFloat(m_shockStrengthID, 1f);

        m_currentCoroutine = null;
    }
}
