//////////////////////////////////////////////////
/// File: InventoryManager.cs
/// Author: Sam Baker
/// Date created: 19/04/20
/// Last edit: 22/04/20
/// Description: Script for managing the inventory
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    //What items are in the inventory and how many
    public List<Item> m_items = new List<Item>();
    public List<int> m_itemNumbers = new List<int>();

    public GameObject[] m_slots = null;
    public GameObject[] m_slots2 = null;

    public RemoveItem[] m_buttons;
    public RemoveItem[] m_buttons2;
    
    public static InventoryManager instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Start()
    {
        DisplayItems();
    }

    private void DisplayItems()
    {
        #region
        //for (int i = 0; i < m_items.Count; i++)
        //{
        //    //Update slot image
        //    m_slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
        //    m_slots[i].transform.GetChild(0).GetComponent<Image>().sprite = m_items[i].m_itemSprite;
        //    //Update slot quantity
        //    m_slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0, 0, 0, 1);
        //    m_slots[i].transform.GetChild(1).GetComponent<Text>().text = m_itemNumbers[i].ToString();

        //    m_slots[i].transform.GetChild(2).gameObject.SetActive(true);
        //}
        #endregion

        for (int i = 0; i < m_slots.Length; i++)
        {
            if(i < m_items.Count)
            {
                //Update slot image
                m_slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                m_slots[i].transform.GetChild(0).GetComponent<Image>().sprite = m_items[i].m_itemSprite;
                //Update slot quantity
                m_slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0, 0, 0, 1);
                m_slots[i].transform.GetChild(1).GetComponent<Text>().text = m_itemNumbers[i].ToString();

                m_slots[i].transform.GetChild(2).gameObject.SetActive(true);

                //Second inv
                m_slots2[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                m_slots2[i].transform.GetChild(0).GetComponent<Image>().sprite = m_items[i].m_itemSprite;
                //Update slot quantity
                m_slots2[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0, 0, 0, 1);
                m_slots2[i].transform.GetChild(1).GetComponent<Text>().text = m_itemNumbers[i].ToString();

                m_slots2[i].transform.GetChild(2).gameObject.SetActive(true);
            }
            else
            {
                //Update slot image
                m_slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                m_slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                //Update slot quantity
                m_slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0, 0, 0, 0);
                m_slots[i].transform.GetChild(1).GetComponent<Text>().text = null;

                m_slots[i].transform.GetChild(2).gameObject.SetActive(false);

                //Second inv
                m_slots2[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                m_slots2[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                //Update slot quantity
                m_slots2[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0, 0, 0, 0);
                m_slots2[i].transform.GetChild(1).GetComponent<Text>().text = null;

                m_slots2[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }

    public void AddItem(Item a_item, int a_amount)
    {
        //item already in inv, add to existing
        if(!m_items.Contains(a_item))
        {
            m_items.Add(a_item);
            m_itemNumbers.Add(a_amount);
        }
        //item not already in inv, add to inv
        else
        {
            for (int i = 0; i < m_items.Count; i++)
            {
                if(a_item == m_items[i])
                {
                    m_itemNumbers[i] += a_amount;
                }
            }
        }
        DisplayItems();
    }

    public bool RemoveItem(Item a_item)
    {
        //If a stack, remove one
        //      if last one remove the item completely
        if(m_items.Contains(a_item))
        {
            for (int i = 0; i < m_items.Count; i++)
            {
                if (a_item == m_items[i])
                {
                    m_itemNumbers[i]--;
                    //remove item
                    if(m_itemNumbers[i] == 0)
                    {
                        m_items.Remove(a_item);
                        m_itemNumbers.Remove(m_itemNumbers[i]);
                    }
                }
            }
            ResetButton();
            DisplayItems();
            return true;
        }
        else
        {
            Debug.Log("This item is not present in the inventory");
            ResetButton();
            DisplayItems();
            return false;
        }
        
    }

    public void ResetButton()
    {
        for (int i = 0; i < m_buttons.Length; i++)
        {
            if(i < m_items.Count)
            {
                m_buttons[i].m_item = m_items[i];
                m_buttons2[i].m_item = m_items[i];
            }
            else
            {
                m_buttons[i].m_item = null;
                m_buttons2[i].m_item = null;
            }
        }
    }
}
