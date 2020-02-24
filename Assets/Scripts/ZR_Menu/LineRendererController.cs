using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererController : MonoBehaviour
{

    private LineRenderer m_lr = null;

    private IEnumerator m_currentEnumerator = null;

    private void Awake()
    {
        m_lr = GetComponent<LineRenderer>();
    }

    public void SetPosition(int a_index, Vector3 a_position)
    {
        m_lr.SetPosition(a_index, a_position);
    }

    public void Fade(float a_speed, float a_alpha)
    {
        if (m_currentEnumerator != null)
            StopCoroutine(m_currentEnumerator);

        m_currentEnumerator = FadeIE(a_speed, a_alpha);
        StartCoroutine(m_currentEnumerator);
    }

    private IEnumerator FadeIE(float a_speed, float a_alpha)
    {
        Color c = m_lr.material.GetColor("_Color");
        float startAlpha = c.a;
        float startTime = Time.time;
        while(c.a != a_alpha)
        {
            c.a = Mathf.MoveTowards(startAlpha, a_alpha, (Time.time - startTime) * a_speed);
            m_lr.material.SetColor("_Color", c);

            yield return null;
        }

        m_currentEnumerator = null;
    }

}
