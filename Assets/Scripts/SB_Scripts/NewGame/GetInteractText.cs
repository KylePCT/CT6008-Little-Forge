//////////////////////////////////////////////////
// File: GetInteractText.cs
// Author: Sam Baker
// Date Created: 23/05/20
// Last Edit: 
// Description: Singleton script used to for retrieving the interaction text
// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInteractText : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private static GetInteractText m_instance;
    public static GetInteractText Instance { get { return m_instance; } }

    public GameObject m_interactionText;
    public GameObject m_invPanel;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake()
    {
        m_instance = this;
    }

    private void Start()
    {
        m_interactionText.SetActive(false);
        m_invPanel.SetActive(false);
    }
}
