//////////////////////////////////////////////////
// Author: Zack Raeburn
// Date created: 23/01/20
// Last edit: 23/01/20
// Description: A custom editor for the FullScreenEffect script
//              Allows for switching order in the fullscreen effects shader list
// Comments: I put way too much effort into this
//////////////////////////////////////////////////

using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(FullScreenEffects))]
public class FullScreenEffects_Editor : Editor
{
    //////////////////////////////////////////////////
    //// Variables
    
    private ReorderableList m_imageEffectsList;

    private FullScreenEffects m_fullScreenEffects
    {
        get { return target as FullScreenEffects; }
    }

    //////////////////////////////////////////////////
    //// Functions

    private void OnEnable()
    {
        m_imageEffectsList = new ReorderableList(m_fullScreenEffects.m_imageEffectsList, typeof(Shader), true, true, true, true);

        m_imageEffectsList.drawHeaderCallback += DrawHeader;
        m_imageEffectsList.drawElementCallback += DrawElement;
        m_imageEffectsList.onAddCallback += AddItem;
        m_imageEffectsList.onRemoveCallback += RemoveItem;
        m_imageEffectsList.onChangedCallback += ChangedItems;
        m_imageEffectsList.onReorderCallback += ChangedItems;
    }

    private void OnDisable()
    {
        m_imageEffectsList.drawHeaderCallback -= DrawHeader;
        m_imageEffectsList.drawElementCallback -= DrawElement;
        m_imageEffectsList.onAddCallback -= AddItem;
        m_imageEffectsList.onRemoveCallback -= RemoveItem;
        m_imageEffectsList.onChangedCallback -= ChangedItems;
        m_imageEffectsList.onReorderCallback -= ChangedItems;
    }

    /// <summary>
    /// Draws the header
    /// </summary>
    /// <param name="a_rect"></param>
    private void DrawHeader(Rect a_rect)
    {
        GUI.Label(a_rect, nameof(m_imageEffectsList));
    }

    /// <summary>
    /// Draws individual elements of the m_imageEffectsList list
    /// </summary>
    /// <param name="a_rect"></param>
    /// <param name="a_index"></param>
    /// <param name="a_active"></param>
    /// <param name="a_focused"></param>
    private void DrawElement(Rect a_rect, int a_index, bool a_active, bool a_focused)
    {
        EditorGUI.BeginChangeCheck();

        string indexString = a_index.ToString();
        int stringPixelBuffer = 6;
        int stringPixelWidth = indexString.Length * 8;
        int totalWidth = stringPixelBuffer + stringPixelWidth;

        EditorGUI.PrefixLabel(new Rect(a_rect.x, a_rect.y, totalWidth, a_rect.height), new GUIContent(indexString));
        m_fullScreenEffects.m_imageEffectsList[a_index] = EditorGUI.ObjectField(new Rect(a_rect.x + totalWidth, a_rect.y, a_rect.width - totalWidth, a_rect.height), m_fullScreenEffects.m_imageEffectsList[a_index], typeof(Shader), false) as Shader;
        if (EditorGUI.EndChangeCheck())
        {
            EditorUtility.SetDirty(target);
            m_fullScreenEffects.ConstructMaterials();
        }
    }

    /// <summary>
    /// When an item is added to the m_imageEffectsList list
    /// </summary>
    /// <param name="a_list"></param>
    private void AddItem(ReorderableList a_list)
    {
        m_fullScreenEffects.m_imageEffectsList.Add(null);

        EditorUtility.SetDirty(target);
    }

    /// <summary>
    /// When an item is removed from the m_imageEffectsList list
    /// </summary>
    /// <param name="a_list"></param>
    private void RemoveItem(ReorderableList a_list)
    {
        m_fullScreenEffects.m_imageEffectsList.RemoveAt(a_list.index);
        m_fullScreenEffects.ConstructMaterials();

        EditorUtility.SetDirty(target);
    }

    /// <summary>
    /// When an item is changed in the m_imageEffectsList list
    /// </summary>
    private void ChangedItems(ReorderableList a_list)
    {
        m_fullScreenEffects.ConstructMaterials();
    }

    /// <summary>
    /// Editor GUI Layout
    /// </summary>
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.Space();

        m_imageEffectsList.DoLayoutList();
    }
}
