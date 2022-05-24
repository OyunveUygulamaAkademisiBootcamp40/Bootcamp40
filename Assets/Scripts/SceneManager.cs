using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour
{
    public static int playerLevel = 1;


    public void OtherScene()
    {
        playerLevel++;
        if (playerLevel%3==0)
        {
            UnitySceneManager.LoadScene(0);
        }
        else
        {
            UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex + 1);
        }
        

    }
    public void RetryScene()
    {
        UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex);
    }
}
