using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

/// <summary>
/// 2021.11.26
/// </summary>

public class SerializationManager
{ 
    public static bool Save(string saveName, object saveData)
    {
        BinaryFormatter formatter = GetBinaryFormarter();

        if (!Directory.Exists(Application.persistentDataPath + "/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }

        string path = Application.persistentDataPath + "/saves" + saveName + ".saves";

        FileStream file = File.Create(path);
        formatter.Serialize(file, saveName);
        file.Close();
        return true;
    }

    public static object Load(string path)
    {
        if(!File.Exists(path))
        {
            return null;
        }

        BinaryFormatter formatter = GetBinaryFormarter();
        FileStream file = File.Open(path, FileMode.Open);

        try
        {
            object save = formatter.Deserialize(file);
            file.Close();
            return save;
        }

        catch
        {
            Debug.LogErrorFormat("failed to LOAD file! at {0}",path);
            file.Close();
            return null;
        }
    }

  public static BinaryFormatter GetBinaryFormarter()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        return formatter;
    }
}
