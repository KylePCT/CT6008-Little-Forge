//////////////////////////////////////////////////
/// File: InventoryToolTip.cs
/// Author: Sam Baker
/// Date created: 21/04/20
/// Last edit: 22/04/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToolTip : MonoBehaviour
{
    public Text m_toolTipText;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowToolTip()
    {
        gameObject.SetActive(true);
    }

    public void CloseToolTip()
    {
        gameObject.SetActive(false);
    }

    public void UpdateToolTip(string a_text)
    {
        m_toolTipText.text = a_text;
    }
    //Mouse hover
    public void Position(Vector2 a_pos)
    {
        transform.localPosition = a_pos;
    }
}
