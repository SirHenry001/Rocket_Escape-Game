using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitLevel()
    {
        SceneManager.LoadScene(0);
    }
    
    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
