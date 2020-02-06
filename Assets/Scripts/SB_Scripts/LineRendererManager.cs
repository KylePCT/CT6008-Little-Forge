//////////////////////////////////////////////////
// Author: Zack Raeburn
// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererManager : MonoBehaviour
{
    private List<LineRenderer> m_activeLR = null;
    private List<LineRenderer> m_inactiveLR = null;

    private GameObject m_lrPrefab = null;

    private int m_arcResolution = 50;
    public int ArcResolution
    {
        get { return m_arcResolution; }
    }

    private float m_fadeSpeed = 0.5f;
    
    private int m_lineColourShaderID;

    private void Awake()
    {
        InitialiseVariables();
    }

    private void Update()
    {
        foreach(LineRenderer lr in m_activeLR)
        {
            FadeInLR(lr);
        }

        foreach(LineRenderer lr in m_inactiveLR)
        {
            FadeOutLR(lr);
        }
    }

    private void FadeInLR(LineRenderer a_lr)
    {
        float a = a_lr.material.GetFloat(m_lineColourShaderID);
        a = Mathf.MoveTowards(a, 1f, Time.deltaTime * m_fadeSpeed);
        a_lr.material.SetFloat(m_lineColourShaderID, a);
    }

    private void FadeOutLR(LineRenderer a_lr)
    {
        float a = a_lr.material.GetFloat(m_lineColourShaderID);
        a = Mathf.MoveTowards(a, 0f, Time.deltaTime * m_fadeSpeed);
        a_lr.material.SetFloat(m_lineColourShaderID, a);
    }

    private void InitialiseVariables()
    {
        m_activeLR = new List<LineRenderer>();
        m_inactiveLR = new List<LineRenderer>();

        m_lrPrefab = Resources.Load("Prefabs/ZR_LineRenderer") as GameObject;

        for (int i = 0; i < HealthController.HealthControllerCount; ++i)
        {
            GameObject lr = Instantiate(m_lrPrefab, transform);
            m_inactiveLR.Add(lr.GetComponent<LineRenderer>());
        }

        m_lineColourShaderID = Shader.PropertyToID("LineOpacity");
    }

    public LineRenderer Activate()
    {
        if (m_inactiveLR.Count == 0)
        {
            GameObject lrObj = Instantiate(m_lrPrefab, transform);
            m_inactiveLR.Add(lrObj.GetComponent<LineRenderer>());
        }

        int index = m_inactiveLR.Count - 1;
        LineRenderer lr = m_inactiveLR[index];
        m_activeLR.Add(lr);
        m_inactiveLR.RemoveAt(index);
        lr.positionCount = m_arcResolution;
        return lr;
    }

    public void Deactivate(LineRenderer a_lr)
    {
        if (m_activeLR.Remove(a_lr))
        {
            m_inactiveLR.Add(a_lr);
        }
    }
}
