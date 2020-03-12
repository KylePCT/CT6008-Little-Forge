using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KT_Typewriter : MonoBehaviour
{
    public float delay = 10f;
    public string fullText;
    private string currentText;

    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<TextMeshProUGUI>().text = currentText;

            Debug.Log(fullText.Length);
            Debug.Log(currentText);
        }

        yield return new WaitForSeconds(delay);
    }
}
