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
    public void LeaveScene()
    {
        SceneManager.LoadScene(6);
    }
    public void GameOverLeaveAgain()
    {
        SceneManager.LoadScene(7);
    }
    public void LeftToBalcony()
    {
        SceneManager.LoadScene(8);
    }
    public void ClosetScene()
    {
        SceneManager.LoadScene(9);
    }
    public void JumpScene()
    {
        SceneManager.LoadScene(10);
    }
    public void ShesStillThere()
    {
        SceneManager.LoadScene(11);
    }
    public void GrabWeaponScene()
    {
        SceneManager.LoadScene(12);
    }
    public void HaelAppears()
    {
        SceneManager.LoadScene(13);
    }
    public void HAMPER()
    {
        SceneManager.LoadScene(14);
    }
    public void WhackHer()
    {
        SceneManager.LoadScene(15);
    }
    public void WinScene()
    {
        SceneManager.LoadScene(16);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

