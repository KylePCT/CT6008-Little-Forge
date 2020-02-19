//////////////////////////////////////////////////
/// File: ShockwaveManager_Editor.cs
/// Author: Zack Raeburn
/// Date Created: 23/01/20
/// Description: A custom editor for the ShockwaveEditor script
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ShockwaveManager))]
public class ShockwaveManager_Editor : Editor
{
    private ShockwaveManager shockwaveManager
    {
        get { return target as ShockwaveManager; }
    }

    /// <summary>
    /// Overides inspector GU
    /// </summary>
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Shockwave!"))
        {
            shockwaveManager.CreateShockwave();
        }
    }
}
