//////////////////////////////////////////////////
// File: LineRendererController.cs
// Author: Zack Raeburn
// Date Created: 28/02/20
// Description: Controls the line renderers attached to the healing/damaging/buffing pillars.
//              Controls 1 line renderer
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererController : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    private LineRenderer m_lr = null;

    private IEnumerator m_currentEnumerator = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Awake()
    {
        m_lr = GetComponent<LineRenderer>();
    }

    /// <summary>
    /// Sets the positions of the line renderer points
    /// </summary>
    /// <param name="a_index"></param>
    /// <param name="a_position"></param>
    public void SetPosition(int a_index, Vector3 a_position)
    {
        m_lr.SetPosition(a_index, a_position);
    }

    /// <summary>
    /// Fades the line renderer material
    /// </summary>
    /// <param name="a_speed"></param>
    /// <param name="a_alpha"></param>
    public void Fade(float a_speed, float a_alpha)
    {
        if (m_currentEnumerator != null)
            StopCoroutine(m_currentEnumerator);

        m_currentEnumerator = FadeIE(a_speed, a_alpha);
        StartCoroutine(m_currentEnumerator);
    }

    /// <summary>
    /// IEnumerator for fading
    /// </summary>
    /// <param name="a_speed"></param>
    /// <param name="a_alpha"></param>
    /// <returns></returns>
    private IEnumerator FadeIE(float a_speed, float a_alpha)
    {
        // Get the starting colour, alpha, and time
        Color c = m_lr.material.GetColor("_Color");
        float startAlpha = c.a;
        float startTime = Time.time;

        // Animate the opacity and set the material colour
        while(c.a != a_alpha)
        {
            c.a = Mathf.MoveTowards(startAlpha, a_alpha, (Time.time - startTime) * a_speed);
            m_lr.material.SetColor("_Color", c);

            yield return null;
        }

        m_currentEnumerator = null;
    }

}
