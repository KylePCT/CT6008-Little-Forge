//////////////////////////////////////////////////
/// File: FadeManager.cs
/// Author: Zack Raeburn
/// Date Created: 19/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    [SerializeField] private Image m_fadeImage = null;

    private bool m_fading = false;
    public bool Fading
    {
        get { return m_fading; }
    }

    private IEnumerator m_currentEnumerator = null;

    public void Fade(float a_speed, float a_alpha)
    {
        if (m_currentEnumerator != null)
            StopCoroutine(m_currentEnumerator);

        m_fading = true;
        m_currentEnumerator = FadeIE(a_speed, a_alpha);
        StartCoroutine(m_currentEnumerator);
    }

    private IEnumerator FadeIE(float a_speed, float a_alpha)
    {
        Color c = m_fadeImage.color;
        float startAlpha = c.a;
        float startTime = Time.time;

        while (c.a != a_alpha)
        {
            c.a = Mathf.MoveTowards(startAlpha, a_alpha, (Time.time - startTime) * a_speed);
            m_fadeImage.color = c;

            yield return null;
        }

        m_fading = false;
        m_currentEnumerator = null;
    }
}
