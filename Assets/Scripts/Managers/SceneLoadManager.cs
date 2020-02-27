//////////////////////////////////////////////////
/// File: LoadManager.cs
/// Author: Zack Raeburn
/// Date Created: 19/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    private FadeManager m_fader = null;

    private IEnumerator m_currentEnumerator = null;
    private Queue<IEnumerator> m_enumeratorQueue = null;

    [SerializeField] private int m_sceneToLoadOnStart = -1;

    [SerializeField] private float m_loadFadeSpeed = 1f;

    private static SceneLoadManager m_instance = null;
    public static SceneLoadManager Instance
    {
        get { return m_instance; }
    }

    private void Awake()
    {
        InitialiseVariables();
    }
        
    private void InitialiseVariables()
    {
        m_instance = this;

        m_fader = GetComponent<FadeManager>();

        if (m_fader == null)
            enabled = false;

        m_enumeratorQueue = new Queue<IEnumerator>();
    }

    private void Start()
    {
        LoadStartScene();
    }

    private void LoadStartScene()
    {
        Scene s = SceneManager.GetSceneByBuildIndex(m_sceneToLoadOnStart);
        if (s == null)
            return;

        LoadScenesLoadingScreen(m_sceneToLoadOnStart);
    }

    public void LoadCharacterCreation()
    {
        Scene s = SceneManager.GetSceneByName("CharacterCreation");
        Debug.Log(s.name);
        if (s == null)
            return;

        LoadScenesLoadingScreen(s.buildIndex);
    }

    private void Update()
    {
        UpdateEnumeratorQueue();
    }

    private void UpdateEnumeratorQueue()
    {
        if (m_currentEnumerator != null || m_enumeratorQueue.Count == 0)
            return;

        m_currentEnumerator = m_enumeratorQueue.Dequeue();
        StartCoroutine(m_currentEnumerator);
    }

    private void QueueEnumerator(IEnumerator a_enumerator)
    {
        m_enumeratorQueue.Enqueue(a_enumerator);
        UpdateEnumeratorQueue();
    }

    public void LoadScenes(params int[] a_sceneIndices)
    {
        IEnumerator enumerator = LoadScenesIE(a_sceneIndices);
        QueueEnumerator(enumerator);
    }

    private IEnumerator LoadScenesIE(params int[] a_sceneIndices)
    {
        List<AsyncOperation> loadOperations = new List<AsyncOperation>(a_sceneIndices.Length);
        for (int i = 0; i < a_sceneIndices.Length; ++i)
        {
            loadOperations.Add(SceneManager.LoadSceneAsync(a_sceneIndices[i], LoadSceneMode.Additive));
            loadOperations[i].allowSceneActivation = false;
        }

        bool doneLoading = false;
        while (!doneLoading)
        {
            int loadedScenes = 0;
            foreach (AsyncOperation async in loadOperations)
            {
                if (async.progress == 0.9f)
                    ++loadedScenes;
                yield return null;
            }

            if (loadedScenes == loadOperations.Count)
                doneLoading = true;
        }

        foreach (AsyncOperation async in loadOperations)
        {
            async.allowSceneActivation = true;
        }

        m_currentEnumerator = null;
    }

    public void LoadScenesLoadingScreen(params int[] a_sceneIndices)
    {
        IEnumerator enumerator = LoadScenesLoadingScreenIE(a_sceneIndices);
        QueueEnumerator(enumerator);
    }

    public IEnumerator LoadScenesLoadingScreenIE(params int[] a_sceneIndices)
    {
        // Fade to loading screen
        m_fader.Fade(m_loadFadeSpeed, 1f);
        while (m_fader.Fading)
            yield return null;

        // Unload scenes
        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            Scene s = SceneManager.GetSceneAt(i);
            if (s.name == "PreLoader")
                continue;
            SceneManager.UnloadSceneAsync(s);
        }

        // Load scenes
        List<AsyncOperation> loadOperations = new List<AsyncOperation>(a_sceneIndices.Length);
        for (int i = 0; i < a_sceneIndices.Length; ++i)
        {
            loadOperations.Add(SceneManager.LoadSceneAsync(a_sceneIndices[i], LoadSceneMode.Additive));
        }

        // Wait for scenes to load
        bool doneLoading = false;
        while (!doneLoading)
        {
            int loadedScenes = 0;
            foreach (AsyncOperation async in loadOperations)
            {
                if (async.progress >= 0.9f)
                    ++loadedScenes;
                yield return null;
            }

            if (loadedScenes == loadOperations.Count)
                doneLoading = true;
        }

        // Wait one frame
        yield return null;

        // Fade from loading screen
        while (m_fader.Fading)
            yield return null;
        m_fader.Fade(m_loadFadeSpeed, 0f);

        m_currentEnumerator = null;
    }
}
