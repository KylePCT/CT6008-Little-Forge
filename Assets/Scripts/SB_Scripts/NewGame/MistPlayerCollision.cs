//////////////////////////////////////////////////
// File: MistPlayerCollision.cs
// Author: Sam Baker
// Date Created: 01/06/20
// Last Edit:
// Description: Script to display some text when collides with player
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MistPlayerCollision : MonoBehaviour
{
    //////////////////////////////////////////////////s
    //// Variables
    public string[] m_dialogue;
    [SerializeField] private float m_displayTime = 3.0f;
    private float m_timer = 0;
    private GameObject m_iteractionText;
    private bool m_collided = false;

    //////////////////////////////////////////////////
    //// Functions
    private void Start()
    {
        m_iteractionText = GetInteractText.Instance.m_interactionText;
    }
    private void Update()
    {
        if (m_collided)
        {
            if (m_timer <= 0)
            {
                m_iteractionText.SetActive(false);
                m_collided = false;
            }
            else
            {
                m_timer -= Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_iteractionText.GetComponent<TextMeshProUGUI>().text = m_dialogue[Random.Range(0, m_dialogue.Length)];
            m_iteractionText.SetActive(true);
            m_timer = m_displayTime;
            m_collided = true;
            Debug.Log("aaaaaaaaaaaaaaa");
        }
    }
}
