//////////////////////////////////////////////////
/// File: PickUpItem.cs
/// Author: Sam Baker
/// Date created: 19/04/20
/// Last edit: 21/04/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private Item m_itemData;

    //please can you set these up sam -kyle
    public int itemQuantity;
    public int sellingValue;


    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if (InventoryManager.instance.m_items.Count < InventoryManager.instance.m_slots.Length)
            {
                Destroy(gameObject);

                InventoryManager.instance.AddItem(m_itemData);
            }
            else
            {
                //Inventory is full
                Debug.Log("Full Inventory! Remove some items");
            }
        }
    }
}
