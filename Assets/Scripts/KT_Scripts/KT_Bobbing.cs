using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code retrieved from https://forum.unity.com/threads/trying-to-simulate-a-ships-rocking-motion-in-the-ocean.465557/ 31/05 16:25
//Adapted for purpose.
public class KT_Bobbing : MonoBehaviour
{
    public float originalY = 67f;
    public float bobbingMultiplier = .5f;

// Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalY + ((float)Math.Sin(Time.time) * bobbingMultiplier), transform.position.z);
    }
}
