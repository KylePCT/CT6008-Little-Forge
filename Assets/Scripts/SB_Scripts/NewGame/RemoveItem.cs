//////////////////////////////////////////////////
/// File: RemoveItem.cs
/// Author: Sam Baker
/// Date created: 19/04/20
/// Last edit: 22/04/20
/// Description: 
/// Comments:
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text;

public class RemoveItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int m_buttonID;
    public Item m_item;

    public InventoryToolTip m_toolTip;
    private Vector2 m_pos;

    [SerializeField] private GameObject m_newCanvas = null;

    private void Start()
    {
        m_buttonID = int.Parse(gameObject.name);
    }

    //Function used to get the item the player wants to remove
    private Item GetItem()
    {
        for (int i = 0; i < InventoryManager.instance.m_items.Count; i++)
        {
            if(m_buttonID == i)
            {
                m_item = InventoryManager.instance.m_items[i];
            }
        }
        return m_item;
    }

    public void RemoveButton()
    {
        InventoryManager.instance.RemoveItem(GetItem());

        m_item = GetItem();
        if(m_item != null)
        {
            m_toolTip.ShowToolTip();
            m_toolTip.UpdateToolTip(GetItemDetailsText(m_item));
        }
        else
        {
            m_toolTip.CloseToolTip();
            m_toolTip.UpdateToolTip("");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetItem();

        if (m_item != null)
        {
            m_toolTip.ShowToolTip();
            m_toolTip.UpdateToolTip(GetItemDetailsText(m_item));

            RectTransformUtility.ScreenPointToLocalPointInRectangle(m_newCanvas.transform as RectTransform, Input.mousePosition, null, out m_pos);
            m_toolTip.Position(m_pos);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_toolTip.CloseToolTip();
        m_toolTip.UpdateToolTip("");
    }

    private string GetItemDetailsText(Item a_item)
    {
        if(a_item== null)
        {
            return "";
        }
        else
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("<b>{0}</b>\n" +
                                        "<size=7>{1}\n</size>" +
                                        "<size=7>Sell Price: ${2}</size>", a_item.m_itemName, a_item.m_itemDescription, a_item.m_sellPrice);
            return stringBuilder.ToString();
        }
    }
}
