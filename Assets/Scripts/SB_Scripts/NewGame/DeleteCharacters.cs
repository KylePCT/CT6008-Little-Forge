//////////////////////////////////////////////////
/// File: DeleteCharacters.cs
/// Author: Sam Baker
/// Date Created: 02/05/20
/// Description: 
//////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteCharacters : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Functions
    public void DeleteCharactersButton()
    {
        for (int i = 0; i < 4; i++)
        {
            SaveGameManager.DeleteCharacter(i);
        }
        SceneManager.LoadScene(0);
    }
}
