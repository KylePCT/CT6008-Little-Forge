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

[RequireComponent(typeof(SphereCollider))]
public class PickUpItem : MonoBehaviour
{
    [SerializeField] private Item m_itemData;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if (InventoryManager.instance.m_items.Count < InventoryManager.instance.m_slots.Length)
            {
                Destroy(gameObject);

                KT_AudioManager.instance.playSound("UIHigh");

                InventoryManager.instance.AddItem(m_itemData, 1);
            }
            else
            {
                //Inventory is full
                Debug.Log("Full Inventory! Remove some items");
            }
        }
    }
}
