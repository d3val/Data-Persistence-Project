using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static string playerName = "";
    public static int sessionScore = 0;

    public static string maxScorePlayerName;
    public static int maxScore;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadMaxScore();

        if (maxScore == 0)
        {
            maxScorePlayerName = "";
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int maxScore;
        public string name;
    }

    



    public static void SaveMaxScore()
    {
        SaveData data = new SaveData();
        data.name = playerName;
        data.maxScore = sessionScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static void LoadMaxScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            maxScore = data.maxScore;
            maxScorePlayerName = data.name;
        }
    }

    
}
