//////////////////////////////////////////////////
/// File: KT_Typewriter.cs
/// Author: Kyle Tugwell
/// Date created: 12/03/20
/// Last edit: 12/03/20
/// Description: Allow all interaction text to animate like a typewriter. 
/// Comments: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KT_Typewriter : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    [SerializeField] TextMeshProUGUI tmpComponent;
    
    public float delay = 0.02f;
    public string fullText;
    private string currentText;
    private int characterIndex;
    private float m_timer;

    //////////////////////////////////////////////////
    //// Functions
    //void OnEnable()
    //{
    //    StartCoroutine(ShowText());
    //}

    //void Update()
    //{
    //    if (fullText != tmpComponent.text)
    //    {
    //        fullText = tmpComponent.text;
    //    }
    //}

    //IEnumerator ShowText()
    //{
    //    int characterIndex = 0;

    //    while(characterIndex++ != fullText.Length)
    //    {
    //        currentText = fullText.Substring(0, characterIndex);
    //        this.GetComponent<TextMeshProUGUI>().text = currentText;

    //        Debug.Log(characterIndex);

    //        yield return new WaitForSeconds(delay);
    //    }
    //}

    void OnEnable()
    {
        fullText = tmpComponent.text;
        characterIndex = 0;
    }

    void Update()
    {
        m_timer += Time.deltaTime;
        if (m_timer >= delay)
        {
            AddLetter();
            m_timer = 0;
        }
        tmpComponent.text = currentText;
    }

    private void AddLetter()
    {
        characterIndex++;
        currentText = fullText.Substring(0, characterIndex);
    }
}