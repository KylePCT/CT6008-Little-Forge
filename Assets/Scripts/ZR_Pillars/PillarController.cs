//////////////////////////////////////////////////
// File: PillarController.cs
// Author: Zack Raeburn
// Date created: 01/02/20
// Description: Controls the beams coming off pilars
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class PillarController : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables

    [SerializeField] private float m_arcYOffset = 5f;
    [SerializeField] private Vector3 m_beamOriginOffset = Vector3.zero;
    private Vector3 BeamOrigin
    {
        get { return transform.position + m_beamOriginOffset; }
    }

    private static LineRendererManager lrm = null;

    [System.Serializable]
    private class Healable
    {
        public HealthController hc;
        public LineRenderer lr;

        public Healable(HealthController a_hc, LineRenderer a_lr)
        {
            hc = a_hc;
            lr = a_lr;
        }
    }
    [SerializeField] private List<Healable> m_healables = null;

    //////////////////////////////////////////////////
    //// Functions

    private void Awake()
    {
        InitialiseVariables();
    }

    /// <summary>
    /// Initialising class variables
    /// </summary>
    private void InitialiseVariables()
    {
        if (lrm == null)
        {
            GameObject lrm = new GameObject("LineRendererManager");
            lrm.transform.parent = transform.parent;
            PillarController.lrm = lrm.AddComponent<LineRendererManager>();
        }

        m_healables = new List<Healable>();
    }

    private void Update()
    {
        UpdateHealables();
    }

    /// <summary>
    /// If healable objects are in range then update the beams that connect them
    /// </summary>
    private void UpdateHealables()
    {
        // For each healable in range
        foreach(Healable h in m_healables)
        {
            Vector3[] trajectory = new Vector3[lrm.ArcResolution];

            // Calculate the arc of the beam
            float height = Mathf.Max(BeamOrigin.y, h.hc.transform.position.y);
            Vector3 middlePos = Vector3.Lerp(BeamOrigin, h.hc.transform.position, 0.5f);
            middlePos.y = height + m_arcYOffset;

            for (int i = 0; i < lrm.ArcResolution; ++i)
            {
                float t = (float)i / (float)lrm.ArcResolution;

                Vector3 p1 = Vector3.Lerp(BeamOrigin, middlePos, t);
                Vector3 p2 = Vector3.Lerp(middlePos, h.hc.ObjectBeamPos, t);
                trajectory[i] = Vector3.Lerp(p1, p2, t);
            }

            // Set the beam positions
            h.lr.SetPositions(trajectory);
        }
    }

    /// <summary>
    /// Adds a healable item when it enters within range
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out HealthController controller))
        {
            if (other.TryGetComponent(out Health health))
            {
                health.AddHealer();
            }
            m_healables.Add(new Healable(controller, lrm.Activate()));
        }
    }

    /// <summary>
    /// Removes a healable item when it gpes out of range
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out HealthController controller))
        {
            if (other.TryGetComponent(out Health health))
            {
                health.RemoveHealer();
            }

            for (int i = 0; i < m_healables.Count; ++i)
            {
                if (controller == m_healables[i].hc)
                {
                    lrm.Deactivate(m_healables[i].lr);
                    m_healables.RemoveAt(i);
                    return;
                }
            }
        }
    }

    /// <summary>
    /// Deactivate line renderers before the object is destroyed
    /// </summary>
    private void OnDestroy()
    {
        foreach(Healable h in m_healables)
        {
            lrm.Deactivate(h.lr);
        }
    }
}
