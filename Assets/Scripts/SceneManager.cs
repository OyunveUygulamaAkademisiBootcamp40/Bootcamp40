
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour
{   public static int playerLevel = 0;
    
    private void Awake()
    {
        preventScreenFlip();
        playerLevel = PlayerPrefs.GetInt("PlayerLevel");
        TotalScore._totalScore = PlayerPrefs.GetInt("TotalScore");
        Debug.Log(playerLevel);
    }

    public void OtherScene()
    {
        if (playerLevel % 1 == 0)
        {
            UnitySceneManager.LoadScene(1);
        }
        else if(playerLevel % 2 == 0)
        {
            UnitySceneManager.LoadScene(2);
        }
        else
        {
            UnitySceneManager.LoadScene(0);
        }
        PlayerPrefs.SetInt("TotalScore", TotalScore._totalScore);
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