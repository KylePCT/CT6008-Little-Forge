using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSaverLoader : MonoBehaviour
{
    private static List<GameObjectSaverLoader> m_currentWorldObjects = null;
    public static List<GameObjectSaverLoader> CurrentWorldObjects
    { 
    get { return m_currentWorldObjects; }
    }
    private int m_objectID = 0;

    private void Awake()
    {
        SetObjectID();

        LoadObjectData();
    }

    private void SetObjectID()
    {
        if (m_currentWorldObjects == null)
            m_currentWorldObjects = new List<GameObjectSaverLoader>();

        m_objectID = m_currentWorldObjects.Count;
        m_currentWorldObjects.Add(this);
    }

    public void LoadObjectData()
    {
        GameObject loadedObject = SaveGameManager.LoadWorldObject(m_objectID);

        if (loadedObject == null)
        {
            Debug.Log("loadedObject returned null");
            return;
        }

        if (loadedObject.GetComponent<GameObjectSaverLoader>().m_objectID == m_objectID)
        {
            Debug.LogError("ID Mismatch");
            return;
        }

        Component[] components = loadedObject.GetComponents(typeof(Component));
        for (int i = 0; i < components.Length; ++i)
        {
            if (components[i] == this)
                continue;

            UnityEditorInternal.ComponentUtility.CopyComponent(components[i]);
            UnityEditorInternal.ComponentUtility.PasteComponentAsNew(gameObject);
        }

    }

    private void OnDestroy()
    {
        SaveObjectData();

        m_currentWorldObjects.Remove(this);
    }

    public void SaveObjectData()
    {
        SaveGameManager.SaveWorldObject(gameObject, m_objectID);
    }
}
