using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Level1Start()
    {
        SceneManager.LoadScene("Episode1");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main-Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

  
}
