using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineRenderer : MonoBehaviour
{
    public Shader m_outlineShader;
    [SerializeField] private Material m_mat = null;

    [SerializeField] private Camera m_mainCam;
    [SerializeField] private Camera m_auxCam;

    private void Start()
    {
        m_mat = new Material(m_outlineShader);

        m_mainCam = GetComponent<Camera>();
        m_auxCam = transform.GetChild(0).GetComponent<Camera>();

        m_auxCam.cullingMask = (1 << LayerMask.NameToLayer("OutlineObject"));

        m_mainCam.depthTextureMode = DepthTextureMode.Depth;
        m_auxCam.depthTextureMode = DepthTextureMode.Depth;
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (m_mat == null)
            return;

        RenderTexture renderTextureMain = new RenderTexture(source.width, source.height, source.depth);
        RenderTexture renderTextureAux = new RenderTexture(source.width, source.height, source.depth);

        Graphics.Blit(source, renderTextureMain);
        renderTextureMain.SetGlobalShaderProperty("_ScreenRender");

        m_auxCam.targetTexture = renderTextureAux;

        foreach (Outline outline in Outline.Outlines)
        {
            int layer = outline.gameObject.layer;
            outline.gameObject.layer = LayerMask.NameToLayer("OutlineObject");

            m_mat.SetColor("_OutlineColour", outline.OutlineColor);
            m_mat.SetFloat("_Depth", outline.OutlineWidth);

            m_auxCam.Render();
            Graphics.Blit(renderTextureAux, renderTextureMain, m_mat);            

            outline.gameObject.layer = layer;
        }

        Graphics.Blit(renderTextureMain, destination);

        // Clean up
        m_auxCam.targetTexture = null;
        Destroy(renderTextureMain);
        Destroy(renderTextureAux);
        renderTextureMain = null;
        renderTextureAux = null;
    }

}
