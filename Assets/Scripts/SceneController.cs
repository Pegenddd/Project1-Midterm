using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void PlayGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("GameScene"); 
    }

    
    public void LoadCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}