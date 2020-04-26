using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Transform startMarker = null;
    public Transform endMarker = null; // create an empty gameobject and assign in inspector

    public float camMovementSpeed = 1;

    private void Start()
    {
        transform.position = startMarker.position;
        transform.rotation = startMarker.rotation;
    }

    public void CamClothes()
    {
        transform.position = endMarker.position;
        transform.rotation = endMarker.rotation;
    }

    public void CamFace()
    {
        transform.position = startMarker.position;
        transform.rotation = startMarker.rotation;
    }
}
