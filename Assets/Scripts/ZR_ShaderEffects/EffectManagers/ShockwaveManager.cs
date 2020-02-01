using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockwaveManager : MonoBehaviour
{
    private int m_shockSizeID = 0;
    private int m_shockThicknessID = 0;
    private int m_shockStrengthID = 0;

    [SerializeField] private float m_targetShockSize = 500;
    [SerializeField] private float m_shockSizeSpeed = 1f;
    [SerializeField] private float m_targetShockStrength = 0f;
    [SerializeField] private float m_shockStrengthSpeed = 1f;

    private IEnumerator m_currentCoroutine = null;
    private Material m_shockwaveMat = null;

    private void Awake()
    {
        m_shockSizeID = Shader.PropertyToID("_ShockSize");
        m_shockThicknessID = Shader.PropertyToID("_ShockThickness");
        m_shockStrengthID = Shader.PropertyToID("_ShockStrength");

        FullScreenEffects.OnConstructMaterials += OnConstructMaterials;
    }

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

    public void CreateShockwave()
    {
        if (m_shockwaveMat == null)
            return;

        if (m_currentCoroutine != null)
            StopCoroutine(m_currentCoroutine);

        m_currentCoroutine = ShockwaveIE();
        StartCoroutine(m_currentCoroutine);
    }

    private IEnumerator ShockwaveIE()
    {
        float shockSize = m_shockwaveMat.GetFloat(m_shockSizeID);
        float shockStrength = m_shockwaveMat.GetFloat(m_shockStrengthID);

        yield return null;

        while (shockSize != m_targetShockSize || shockStrength != m_targetShockStrength)
        {
            shockSize = Mathf.MoveTowards(shockSize, m_targetShockSize, Time.deltaTime * m_shockSizeSpeed);
            shockStrength = Mathf.MoveTowards(shockStrength, m_targetShockStrength, Time.deltaTime * m_shockStrengthSpeed);

            m_shockwaveMat.SetFloat(m_shockSizeID, shockSize);
            m_shockwaveMat.SetFloat(m_shockStrengthID, shockStrength);

            yield return null;
        }

        m_shockwaveMat.SetFloat(m_shockSizeID, 0f);
        m_shockwaveMat.SetFloat(m_shockStrengthID, 1f);

        m_currentCoroutine = null;
    }
}
