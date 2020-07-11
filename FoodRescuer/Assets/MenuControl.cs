using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("PlayGame Called");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1f;
        Debug.Log("RestartGame Called");
    } 
    public void BackButton()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("BackButton Called");
    }
    public void NextButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("NextButton Called");
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
        Debug.Log("HomeButton Called");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Called");
    }

}
