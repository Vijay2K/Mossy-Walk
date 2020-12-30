using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool isGamePaused;    

    private void Start()
    {        
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (isGamePaused)
        {
            PauseButton();
        }
        else
        {
            ResumeButton();
        }
    } 

    public void PlayButton(string level)
    {
        
        SceneManager.LoadScene(level);         
        
    }

    public void Home(int scene)
    {
       
        SceneManager.LoadScene(scene);
    }    

    public void Settings(string level)
    {
        //Setting 
        Debug.Log("This is the setting");
        SceneManager.LoadScene(level);
    }

    public void CreditsMenu(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void PauseButton()
    {
     
        isGamePaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void ResumeButton()
    {        
        isGamePaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void RestartButton()
    {
      
        Time.timeScale = 1f;
        isGamePaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);         
    }

    public void LoadNextLevel() 
    {
      
        LevelLoader.Instance.StartAnim(SceneManager.GetActiveScene().buildIndex + 1);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu(string menu) 
    {
        //Menu
       
        Debug.Log("Main Menu");
        SceneManager.LoadScene(menu);
    }

    public void Quit()
    {
       
        Application.Quit();
    }

}
