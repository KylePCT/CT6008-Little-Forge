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

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Shockwave!"))
        {
            shockwaveManager.CreateShockwave();
        }
    }
}
