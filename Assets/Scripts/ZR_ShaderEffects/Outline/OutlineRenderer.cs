//////////////////////////////////////////////////
// File: OutlineRenderer.cs
// Author: Zack Raeburn
// Date Created: 19/02/20
// Description: Renders an outline on objects with an
//              Outline script attached
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineRenderer : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    public Shader m_outlineShader;
    [SerializeField] private Material m_mat = null;

    [SerializeField] private Camera m_mainCam;
    [SerializeField] private Camera m_auxCam;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        InitialiseVariables();
    }

    /// <summary>
    /// Intialise all variables
    /// </summary>
    private void InitialiseVariables()
    {
        m_mat = new Material(m_outlineShader);

        m_mainCam = GetComponent<Camera>();
        m_auxCam = transform.GetChild(0).GetComponent<Camera>();

        m_auxCam.cullingMask = (1 << LayerMask.NameToLayer("OutlineObject"));

        m_mainCam.depthTextureMode = DepthTextureMode.Depth;
        m_auxCam.depthTextureMode = DepthTextureMode.Depth;
    }

    /// <summary>
    /// Rendering outlines for objects that need it and pasting the outlines onto the cameras previous render
    /// </summary>
    /// <param name="source"></param>
    /// <param name="destination"></param>
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (m_mat == null)
            return;

        RenderTexture renderTextureMain = new RenderTexture(source.width, source.height, source.depth);
        RenderTexture renderTextureAux = new RenderTexture(source.width, source.height, source.depth);

        // Render the scene
        Graphics.Blit(source, renderTextureMain);
        renderTextureMain.SetGlobalShaderProperty("_ScreenRender");

        m_auxCam.targetTexture = renderTextureAux;
        
        // Render outlines
        foreach (Outline outline in Outline.Outlines)
        {
            // Set object to seperate layer
            int layer = outline.gameObject.layer;
            outline.gameObject.layer = LayerMask.NameToLayer("OutlineObject");

            // Set outline settings
            m_mat.SetColor("_OutlineColour", outline.OutlineColor);
            m_mat.SetFloat("_Depth", outline.OutlineWidth);

            // Render only the object on a blank background
            m_auxCam.Render();
            // Store outline in render texture for later
            Graphics.Blit(renderTextureAux, renderTextureMain, m_mat);            

            // Reset object layer
            outline.gameObject.layer = layer;
        }

        // Paste outlines onto main camera render
        Graphics.Blit(renderTextureMain, destination);

        // Clean up
        m_auxCam.targetTexture = null;
        Destroy(renderTextureMain);
        Destroy(renderTextureAux);
        renderTextureMain = null;
        renderTextureAux = null;
    }

}
