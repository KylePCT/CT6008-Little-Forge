using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowards : MonoBehaviour
{
    [SerializeField] private Vector3 m_pos;

    // Update is called once per frame
    void Update()
    {
        Vector3 lookPos = new Vector3(m_pos.x, transform.position.y, m_pos.z);
        Vector3 lookDir = (transform.position - lookPos).normalized;

        Quaternion look = Quaternion.LookRotation(lookDir, transform.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, look, 0.25f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(m_pos, 0.5f);
    }
}
