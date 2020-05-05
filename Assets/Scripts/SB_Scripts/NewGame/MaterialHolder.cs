//////////////////////////////////////////////////
// File: MaterialHolder.cs
// Author: Sam Baker
// Date Created: 05/05/20
// Description: Script used for accessability of materials on buttons.
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialHolder : MonoBehaviour
{
    [SerializeField] private Material m_mat;

    public Material GetMat() => m_mat;
}
