using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialSceneFlow : MonoBehaviour
{
    // Start is called before the first frame update
    public static EssentialSceneFlow instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // In first scene, make us the singleton.
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            EssentialSceneFlow.instance.transform.GetChild(0).GetChild(0).transform.position = this.transform.GetChild(0).GetChild(0).transform.position;
            Destroy(gameObject); // On reload, singleton already set, so destroy duplicate.
        }
    }
}
