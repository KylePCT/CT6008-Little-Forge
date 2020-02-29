//////////////////////////////////////////////////
// File: SceneLoadManager.cs
// Author: Zack Raeburn
// Date Created: 19/02/20
// Description: Manages loading between scenes
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

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

    //////////////////////////////////////////////////
    //// Functions

    private void Awake()
    {
        InitialiseVariables();
    }
    
    /// <summary>
    /// Initialise all script variables
    /// </summary>
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

    /// <summary>
    /// Load the intial game scene, should be the main menu
    /// </summary>
    private void LoadStartScene()
    {
        Scene s = SceneManager.GetSceneByBuildIndex(m_sceneToLoadOnStart);
        if (s == null)
            return;

        LoadScenesLoadingScreen(m_sceneToLoadOnStart);
    }

    /// <summary>
    /// Load the character creation scene by build index, should be 2, can be checked in build settings
    /// </summary>
    public void LoadCharacterCreation()
    {
        LoadScenesLoadingScreen(2);
    }

    private void Update()
    {
        UpdateEnumeratorQueue();
    }

    /// <summary>
    /// IEnumerators can be queued, this goes through and starts the next one if there is one available
    /// </summary>
    private void UpdateEnumeratorQueue()
    {
        if (m_currentEnumerator != null || m_enumeratorQueue.Count == 0)
            return;

        m_currentEnumerator = m_enumeratorQueue.Dequeue();
        StartCoroutine(m_currentEnumerator);
    }

    /// <summary>
    /// Queue an IEnumerator
    /// </summary>
    /// <param name="a_enumerator"></param>
    private void QueueEnumerator(IEnumerator a_enumerator)
    {
        m_enumeratorQueue.Enqueue(a_enumerator);
        UpdateEnumeratorQueue();
    }

    /// <summary>
    /// Load scenes asynchronously by build index
    /// </summary>
    /// <param name="a_sceneIndices"></param>
    public void LoadScenes(params int[] a_sceneIndices)
    {
        IEnumerator enumerator = LoadScenesIE(a_sceneIndices);
        QueueEnumerator(enumerator);
    }

    /// <summary>
    /// Loads scenes asynchronously and waits for them to complete loading before activating
    /// </summary>
    /// <param name="a_sceneIndices"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Load scenes asynchronously by build index with a loading screen
    /// </summary>
    /// <param name="a_sceneIndices"></param>
    public void LoadScenesLoadingScreen(params int[] a_sceneIndices)
    {
        IEnumerator enumerator = LoadScenesLoadingScreenIE(a_sceneIndices);
        QueueEnumerator(enumerator);
    }

    /// <summary>
    /// Fades to a loading screen, unloads currently loaded screens (except the preloader scene we need that), then asynchronously loads the next scenes and unfades
    /// </summary>
    /// <param name="a_sceneIndices"></param>
    /// <returns></returns>
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
