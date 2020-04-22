//////////////////////////////////////////////////
/// File: Item.cs
/// Author: Sam Baker
/// Date created: 18/04/21
/// Last edit: 21/04/21
/// Description: 
/// Comments: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Sam/Item")]
public class Item : ScriptableObject
{
    public string m_itemName = "";
    [Tooltip("Desription is not used in the prototype")]
    public string m_itemDescription = "";
    public Sprite m_itemSprite = null;
    public int m_sellPrice = 0;
}
