
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour
{   public static int playerLevel = 1;
    
    private void Awake()
    {
        preventScreenFlip();
        playerLevel = PlayerPrefs.GetInt("PlayerLevel");
    }

    public void OtherScene()
    {
        Debug.Log(playerLevel);

        if (playerLevel % 3 == 0)
        {
            UnitySceneManager.LoadScene(0);
        }
        else
        {   
            
            UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex + 1);
        }

        playerLevel++;
        PlayerPrefs.SetInt("PlayerLevel", playerLevel);
    }
    public void RetryScene()
    {
        UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex);
    }

    private void preventScreenFlip()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void OtherSceneActive()
    {
        Invoke(nameof(OtherScene), 2f);
    }
}