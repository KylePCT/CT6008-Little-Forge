//////////////////////////////////////////////////
// File: SaveGameManager.cs
// Author: Zack Raeburn
// Date Created: 27/02/20
// Last Edit: 03/05/20 - Sam Baker
// Description: Manages saving and loading game save files
// Comments: Edited to save the data of the character - Sam
//////////////////////////////////////////////////

using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// A class to store individual character information, put values to be saved in here
/// </summary>
[System.Serializable]
public class SaveSlot
{
    // Required for saves to work
    public int m_saveSlotID;

    // Save data
    public string m_name = null;
    public float m_money = 0;

    // Save Data for the customisation of the characters - Sam Baker
    public string m_skinColour = null;
    public string m_hairType = null;
    public string m_hairColour = null;
    public string m_eyeType = null;
    public float[] m_eyeColour = new float[3];
    public string m_noseType = null;
    public string m_mouthType = null;
    public string m_bodyTopType = null;
    public float[] m_bodyTopColour = new float[3];
    public string m_bodyBottomType = null;
    public float[] m_bodyBottomColour = new float[3];
    public float[] m_shoeColour = new float[3];

    public SaveSlot(int a_saveSlot)
    {
        m_saveSlotID = a_saveSlot;
    }
}

public static class SaveGameManager
{
    /// <summary>
    /// Header class to track all characters/save slots
    /// </summary>
    [System.Serializable]
    private class Header
    {
        [System.Serializable]
        public class Data
        {
            public string[] m_characterFilePaths;

            // Game options
            public float m_audioVolume;
            public float m_sensitivity;
        }
        public static Data data;

        // We only have 4 save slots so this array only needs to be 4 long
        static Header()
        {
            data = new Data();

            data.m_characterFilePaths = new string[4]
            {
                "",
                "",
                "",
                ""
            };

            data.m_audioVolume = 10f;
            data.m_sensitivity = 10f;
        }
    }

    //////////////////////////////////////////////////
    //// Variables

    // For saving save slots so they can be used repetedly without loading/saving more than once
    private static SaveSlot m_mainSaveSlot = null;

    // Const file paths
    private static string m_filePath
    {
        get { return Application.persistentDataPath + "/Data/Prefs/"; }
    }
    private static string m_headerPath
    {
        get { return m_filePath + "header.bin"; }
    }

    //////////////////////////////////////////////////
    //// Functions

    /// <summary>
    /// Header saving
    /// </summary>
    public static void SaveHeader()
    {
        Debug.Log("Saving header");

        // Create the save file directory if it does no exist
        if (!Directory.Exists(m_filePath))
        {
            Directory.CreateDirectory(m_filePath);
        }

        BinaryFormatter m_formatter = new BinaryFormatter();

        FileStream stream = new FileStream(m_headerPath, FileMode.OpenOrCreate);
        m_formatter.Serialize(stream, Header.data);
        stream.Close();
    }

    /// <summary>
    /// Header loading
    /// </summary>
    public static void LoadHeader()
    {
        if (File.Exists(m_headerPath))
        {
            BinaryFormatter m_formatter = new BinaryFormatter();

            FileStream stream = new FileStream(m_headerPath, FileMode.Open);
            Header.data = m_formatter.Deserialize(stream) as Header.Data;
            stream.Close();
        }
        else
        {
            Debug.Log("SaveManager.cs::SaveManager::LoadHeader - Cannot load header, header file does not exist. Saving header instead");
            SaveHeader();
        }
    }

    /// <summary>
    /// Character saving, loading, and creation
    /// Returns the save slot of the character
    /// </summary>
    /// <param name="a_saveSlot"></param>
    public static void CreateCharacter(int a_saveSlot)
    {
        // Creating new char info
        SaveSlot newCharacter = new SaveSlot(a_saveSlot);
        Header.data.m_characterFilePaths[a_saveSlot] = m_filePath + "slot_" + a_saveSlot.ToString() + ".bin";
        SetMainCharFile(newCharacter);

        SaveHeader();

        SaveCharacter(newCharacter);
    }

    public static void SaveCharacter(SaveSlot a_playInfo)
    {
        // Saving
        BinaryFormatter m_formatter = new BinaryFormatter();

        FileStream stream = new FileStream(Header.data.m_characterFilePaths[a_playInfo.m_saveSlotID], FileMode.OpenOrCreate);
        m_formatter.Serialize(stream, a_playInfo);
        stream.Close();
    }

    /// <summary>
    /// Removing character from header and deleting save file from disk
    /// </summary>
    /// <param name="a_saveSlot"></param>
    public static void DeleteCharacter(int a_saveSlot)
    {
        string filePath = m_filePath + "slot_" + a_saveSlot.ToString() + ".bin";
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        Header.data.m_characterFilePaths[a_saveSlot] = "";
    }

    /// <summary>
    /// Loading character info from a save file
    /// </summary>
    /// <param name="a_slot"></param>
    /// <returns></returns>
    public static SaveSlot LoadCharacter(int a_slot)
    {
        SaveSlot a_characterInfo;

        if (File.Exists(Header.data.m_characterFilePaths[a_slot]))
        {
            BinaryFormatter m_formatter = new BinaryFormatter();

            FileStream stream = new FileStream(Header.data.m_characterFilePaths[a_slot], FileMode.Open);
            a_characterInfo = m_formatter.Deserialize(stream) as SaveSlot;
            stream.Close();

            // DeSerialising inventory from the save file
            //InventoryManager.DeSerialise(a_characterInfo.m_inventory);
        }
        else
        {
            Debug.Log("SaveManager.cs::SaveManager::LoadCharacter - Cannot load character, character file does not exist");
            a_characterInfo = null;
        }

        return a_characterInfo;
    }

    /// <summary>
    /// Stores a save file as the 'main' one
    /// Basically so I can get it later if I need without reading the save file again
    /// </summary>
    /// <param name="a_slot"></param>
    public static void SetMainCharFile(SaveSlot a_slot)
    {
        m_mainSaveSlot = a_slot;
    }

    /// <summary>
    /// Returns the 'main' save file
    /// </summary>
    /// <returns></returns>
    public static SaveSlot GetMainCharFile()
    {
        return m_mainSaveSlot;
    }

    /// <summary>
    /// Checks if a save slot has character info or not
    /// </summary>
    /// <param name="a_saveSlot"></param>
    /// <returns></returns>
    public static bool IsSaveSlotOccupied(int a_saveSlot)
    {
        if (Header.data.m_characterFilePaths[a_saveSlot] == "")
            return false;

        return true;
    }

    //////////////////////////////////////////////////
    //// Options setters and getters

    public static void SetOptions(float a_audioVolume, float a_sensitivity)
    {
        Header.data.m_audioVolume = Mathf.Clamp(a_audioVolume, 0f, 10f);
        Header.data.m_sensitivity = Mathf.Clamp(a_sensitivity, 0f, 10f);
    }

    public static void GetOptions(out float a_audioVolume, out float a_sensitivity)
    {
        a_audioVolume = Header.data.m_audioVolume;
        a_sensitivity = Header.data.m_sensitivity;
    }

    /// <summary>
    /// Outputs some debug info to the console
    /// </summary>
    public static void DebugSaveManager()
    {
        if (Header.data.m_characterFilePaths == null)
        {
            Debug.Log("Header.m_characterFilePaths == null");
            return;
        }

        Debug.ClearDeveloperConsole();

        int saveCount = 0;
        for (int i = 0; i < 4; ++i)
        {
            if (Header.data.m_characterFilePaths[i] != "")
                ++saveCount;
        }
        Debug.Log(saveCount);

        for (int i = 0; i < 4; ++i)
        {
            Debug.Log(Header.data.m_characterFilePaths[i]);
        }
    }
}
