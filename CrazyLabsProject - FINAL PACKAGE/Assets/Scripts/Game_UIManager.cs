using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_UIManager : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public Button ExitButton;
    //public Button HitButton;
    //public GameObject GM;
    public GameObject Button;

    public void Start()
    {
        //HitButton.gameObject.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        Button.gameObject.SetActive(false);
       
        //HitButton.gameObject.SetActive(false);
        //HitButton.enabled = false;
        
        //PauseButton.gameObject.SetActive(false);
        //ResumeButton.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Button.gameObject.SetActive(true);
        //HitButton.gameObject.SetActive(true);
        //PauseButton.gameObject.SetActive(true);
        //ResumeButton.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
