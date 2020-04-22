//////////////////////////////////////////////////
/// File: KT_CirclePause.cs
/// Author: Kyle Tugwell
/// Date created: 19/03/20
/// Last edit: 19/04/20 - sam
/// Description: A script to manage a circular pause menu which detects the mouse position to decide which wedge is activated.
/// Comments: inventory implementation - sam
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KT_CirclePause : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    public List<MenuButton> buttons = new List<MenuButton>();
    private Vector2 mousePos;
    private Vector2 fromVector2M = new Vector2(0.5f, 1.0f);
    private Vector2 centerCircle = new Vector2(0.5f, 0.5f);
    private Vector2 toVector2M;

    [SerializeField] private GameObject m_invCanvas = null;

    public int menuItems;
    public int currentMenuItem;
    private int oldMenuItem;

    //////////////////////////////////////////////////
    //// Functions
    void Start()
    {
        //detect menuItems through numbers of buttons
        menuItems = buttons.Count; 

        //set default colour for all buttons
        foreach(MenuButton button in buttons)
        {
            button.sceneImage.color = button.idleColour;
        }

        currentMenuItem = 0;
        oldMenuItem = 0;
    }

    void Update()
    {
        //get the currentMenuItem through moust position
        getCurrentMenuItem();

        //click to do a thing on the menu
        if(Input.GetMouseButtonDown(0))
        {
            buttonAction();
        }
    }

    public void getCurrentMenuItem()
    {
        //get mousePosition through inputs and toVector2M by allocating position to screen resolution
        mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        toVector2M = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);

        //where on the mouse is the screen, determine the angle and then convert it to degrees from radians
        float mouseAngle = (Mathf.Atan2(fromVector2M.y - centerCircle.y, fromVector2M.x - centerCircle.x) - Mathf.Atan2(toVector2M.y - centerCircle.y, toVector2M.x - centerCircle.x)) * Mathf.Rad2Deg;

        //make sure the angle does not go below 0 e.g. converts -90 to 270
        if (mouseAngle < 0)
        {
            mouseAngle += 360;
        }

        //shows which wedge is selected through the angle
        currentMenuItem = (int)(mouseAngle / (360 / menuItems));

        //change colours to show feedback dependant on highlight
        if (currentMenuItem != oldMenuItem)
        {
            buttons[oldMenuItem].sceneImage.color = buttons[oldMenuItem].idleColour;
            oldMenuItem = currentMenuItem;
            buttons[currentMenuItem].sceneImage.color = buttons[currentMenuItem].highlightColour;

            LeanTween.scale(this.gameObject, new Vector3(1.2f, 1.2f, 1.2f), 0.2f);
        }
    }

    //when buttons are pressed
    public void buttonAction()
    {
        buttons[currentMenuItem].sceneImage.color = buttons[currentMenuItem].downColour;

        //wedge actions
        if(currentMenuItem == 0)
        {
            Debug.Log("0 TR pressed");
        }

        else if(currentMenuItem == 1)
        {
            Debug.Log("1 M pressed");
        }        
        
        else if(currentMenuItem == 2)
        {
            //Open the inventory
            Debug.Log("2 TL pressed");
            m_invCanvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

//fields for colours and images which allow them to work in the list for added functionality and efficiency
[System.Serializable]
public class MenuButton
{
    public string name;
    public Image sceneImage;
    public Color idleColour = Color.white;
    public Color highlightColour = Color.grey;
    public Color downColour = Color.gray;
}