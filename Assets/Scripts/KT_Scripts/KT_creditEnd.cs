using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KT_creditEnd : MonoBehaviour
{
    public GameObject creditHolder;
    
    // Update is called once per frame
    void Update()
    {
        if (creditHolder.transform.position.y >= 3000)
        {
            SceneManager.LoadScene("PreLoader");
        }
    }
}
