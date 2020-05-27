//////////////////////////////////////////////////
/// File: CreditScene.cs
/// Author: Sam Baker
/// Date created: 27/05/2020
/// Last edit: 27/05/2020
/// Description: Script controlling the credit scene.
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScene : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    private InputSystem m_inputSystem = null;
    private bool m_speedUp = false;
    [SerializeField] private Animator m_animator = null;

    //////////////////////////////////////////////////
    //// Functions
    private void Awake() => m_inputSystem = new InputSystem();
    public void OnEnable() => m_inputSystem.Player.Enable();
    public void OnDisable() => m_inputSystem.Player.Disable();

    private void Update()
    {
        //Exit
        if (m_inputSystem.Player.ESCkey.triggered)
        {
            SceneManager.LoadScene("PreLoader");
        }

        //Speed up
        if (m_inputSystem.Player.Jump.triggered)
        {
            if(!m_speedUp)
            {
                m_animator.speed = 2.5f;
            }
            else
            {
                m_animator.speed = 1.0f;
            }
            m_speedUp = !m_speedUp;
        }
        
    }
}
