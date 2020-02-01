//////////////////////////////////////////////////
// Author: Zack Raeburn
// Date created: 23/01/20
// Last edit: 23/01/20
// Description: Manages full screen shader effects.
//              Takes the current rendered image from the main camera and applies a shader file to it, outputting the new image to the camera
// Comments:
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FullScreenEffects : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    [HideInInspector]
    public List<Shader> m_imageEffectsList = null;

    public List<Material> m_materials = null;
    public List<Material> Materials
    {
        get { return m_materials; }
    }

    public bool DisableEffects = false;

    public delegate void OnConstructMaterialsCallbackDelegate(FullScreenEffects a_sender);
    public static OnConstructMaterialsCallbackDelegate OnConstructMaterials = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Start()
    {
        ConstructMaterials();
    }

    /// <summary>
    /// Constructs m_materials array which contains materials of the shaders provided
    /// </summary>
    public void ConstructMaterials()
    {
        if (m_materials == null || m_imageEffectsList == null)
                return; // Early out

        m_materials = new List<Material>();
        for (int i = 0; i < m_imageEffectsList.Count; ++i)
        {
            if (m_imageEffectsList[i] == null)
                continue;

            m_materials.Add(new Material(m_imageEffectsList[i]));
        }

        if (OnConstructMaterials != null)
            OnConstructMaterials.Invoke(this);
    }

    private void OnRenderImage(RenderTexture a_source, RenderTexture a_destination)
    {
        if (m_materials.Count == 0 || DisableEffects)
        {
            Graphics.Blit(a_source, a_destination);
            return;
        }

        RenderTexture temp1 = RenderTexture.GetTemporary(a_source.width, a_source.height, 0, a_source.format);
        RenderTexture temp2 = RenderTexture.GetTemporary(a_source.width, a_source.height, 0, a_source.format);
        
        RenderTexture final = temp1;
        
        Graphics.Blit(a_source, temp1, m_materials[0]);
        
        for (int i = 1; i < m_materials.Count; ++i)
        {
            if (i % 2 == 1)
            {
                Graphics.Blit(temp1, temp2, m_materials[i]);
                final = temp2;
            }
            else
            {
                Graphics.Blit(temp2, temp1, m_materials[i]);
                final = temp1;
            }
        }
        
        Graphics.Blit(final, a_destination);

        // I forgot these and Unity memory leaked 12GB and hard crashed my computer :(
        temp1.Release();
        temp2.Release();
        final.Release();
    }
}
