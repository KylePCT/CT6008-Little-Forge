//////////////////////////////////////////////////
// File: HealthController.cs
// Author: Zack Raeburn
// Date created: 01/02/20
// Description: The script that PillarController will draw a beam to
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private Vector3 m_beamOffset = Vector3.zero;
    public Vector3 ObjectBeamPos
    {
        get { return transform.position + m_beamOffset; }
    }

    // For determing heal/damage/buff amount per tick
    private static int m_healthControllerCount = 0;
    public static int HealthControllerCount
    {
        get { return m_healthControllerCount; }
    }

    //////////////////////////////////////////////////
    //// Functions

    private void OnEnable()
    {
        ++m_healthControllerCount;
    }

    private void OnDisable()
    {
        --m_healthControllerCount;
    }
}
