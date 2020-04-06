//////////////////////////////////////////////////
/// File: RotateChar.cs
/// Author: Kyle Tugwell
/// Date created: 02/04/20
/// Last edit: 02/04/20
/// Description: Enable the player to rotate their character while customizing.
/// Comments: 
//////////////////////////////////////////////////

using UnityEngine;

public class RotateChar : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    
    //Rotation Speed
    public float rotationSpeed = 250.0f;

    //Object to Rotate
    [SerializeField] private GameObject objectToRotate = null;

    //Object containing area to drag inside
    [SerializeField] private RectTransform boundingTransform = null;

    private bool rotating = false;

    //////////////////////////////////////////////////
    //// Functions
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position, if it's inside the boundary, set rotating to true
            Vector2 localMousePosition = boundingTransform.InverseTransformPoint(Input.mousePosition);
            if (boundingTransform.rect.Contains(localMousePosition))
            {
                rotating = true;
            }
        }

        //if the mouseButton isn't down, don't rotate
        if (rotating && Input.GetMouseButtonUp(0))
        {
            rotating = false;
        }

        //if it is down, rotate the object
        if (rotating)
        {
            RotateObject();
        }
    }

    //Rotate relative to the mouse speed, position on X and time
    private void RotateObject()
    {
        objectToRotate.transform.Rotate(new Vector3(0.0f, -Input.GetAxis("Mouse X"), 0.0f) * Time.deltaTime * rotationSpeed);
    }

}