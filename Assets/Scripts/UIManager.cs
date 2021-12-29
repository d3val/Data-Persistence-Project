using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{


    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

 
}
