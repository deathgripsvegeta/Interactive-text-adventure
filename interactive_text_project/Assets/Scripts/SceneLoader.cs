using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void  LoadNextScene()
    {
     int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
     SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    
    }
    
     public void HamperScene()
    {
        SceneManager.LoadScene(4);
    
    }
     public void BalconyScene()
    {
        SceneManager.LoadScene(5);
    
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

