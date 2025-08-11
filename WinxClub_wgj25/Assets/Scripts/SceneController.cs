using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
     public static SceneController Instance;
     
     private void Awake()
     {
         if (Instance != null && Instance != this)
         {
             Destroy(gameObject);
         }
         else
         {
             Instance = this;
         }
        
         DontDestroyOnLoad(gameObject);
     }
     
    public void LoadNextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 > SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogWarning("Última cena já está carregada.");
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousScene()
    {
        if (SceneManager.GetActiveScene().buildIndex - 1 < 0)
        {
            Debug.LogWarning("Primeira cena já está carregada.");
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Debug.LogWarning("QuitGame");
        Application.Quit();
    }
}
