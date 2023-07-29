using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public int bestScore;
    public string bestPlayer;
}

public class SaveManager : MonoBehaviour
{
    SaveData data = new SaveData();
    
    public void SaveData()
    {
        data.bestScore = GameObject.Find("StartAndSave").GetComponent<StartAndSave>().bestScore;
        data.bestPlayer = GameObject.Find("StartAndSave").GetComponent<StartAndSave>().bestPlayer;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            GameObject.Find("StartAndSave").GetComponent<StartAndSave>().bestScore = data.bestScore;
            GameObject.Find("StartAndSave").GetComponent<StartAndSave>().bestPlayer = data.bestPlayer;
        }
    }
}