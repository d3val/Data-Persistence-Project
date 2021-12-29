using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenuHandler : MonoBehaviour
{

    public void SetPlayerName()
    {
        Debug.Log("XD");
        Text nameField = GameObject.Find("IF Name").transform.GetChild(2).GetComponent<Text>();
        ScoreManager.playerName = nameField.text;

    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
