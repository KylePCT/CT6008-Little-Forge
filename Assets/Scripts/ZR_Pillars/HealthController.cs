//////////////////////////////////////////////////
// Author: Zack Raeburn
// Description: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Vector3 m_beamOffset;
    public Vector3 ObjectBeamPos
    {
        get { return transform.position + m_beamOffset; }
    }

    private static int m_healthControllerCount = 0;
    public static int HealthControllerCount
    {
        get { return m_healthControllerCount; }
    }

    private void OnEnable()
    {
        ++m_healthControllerCount;
    }

    private void OnDisable()
    {
        --m_healthControllerCount;
    }
}
