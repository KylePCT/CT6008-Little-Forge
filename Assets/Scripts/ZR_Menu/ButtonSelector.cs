//////////////////////////////////////////////////
/// File: ButtonSelector.cs
/// Author: Zack Raeburn
/// Date Created: 19/02/20
/// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelector : MonoBehaviour
{
    [SerializeField] private float m_snapSpeed = 1f;

    private Transform m_lastSnap = null;
    public Transform LastSnap
    {
        get { return m_lastSnap; }
    }

    private IEnumerator m_currentEnumerator = null;

    public void SnapTo(Transform a_transform)
    {
        if (m_currentEnumerator != null)
            StopCoroutine(m_currentEnumerator);

        m_currentEnumerator = SnapToIE(a_transform);
        StartCoroutine(m_currentEnumerator);
    }

    private IEnumerator SnapToIE(Transform a_transform)
    {
        m_lastSnap = a_transform;

        Vector3 startPos = transform.position;
        float startTime = Time.time;
        float distance = Vector3.Distance(startPos, a_transform.position);

        while(transform.position != a_transform.position)
        {
            float t = (Time.time - startTime) * m_snapSpeed;
            float x = Mathf.SmoothStep(startPos.x, a_transform.position.x, t);
            float y = Mathf.SmoothStep(startPos.y, a_transform.position.y, t);
            transform.position = new Vector3(x, y, transform.position.z);

            yield return null;
        }

        m_currentEnumerator = null;
    }
}
