//////////////////////////////////////////////////
/// File: SaveItem.cs
/// Author: Zack Raeburn
/// Date Created: 27/02/20
/// Description: For setting save information into UI objects
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveItem : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    [SerializeField] private TextMeshProUGUI m_name = null;
    [SerializeField] private TextMeshProUGUI m_money = null;

    public SaveSlot m_characterFile = null;

    //////////////////////////////////////////////////
    //// Functions

    public void SetEmpty()
    {
        m_name.text = "Empty";
        m_money.text = "";
    }

    public void SetName(string a_name)
    {
        m_name.text = a_name;
    }

    public void SetBottomText(string a_string)
    {
        m_money.text = a_string;
    }

}
