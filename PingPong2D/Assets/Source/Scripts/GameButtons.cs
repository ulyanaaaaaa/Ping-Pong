using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public void OnExit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void OnRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
