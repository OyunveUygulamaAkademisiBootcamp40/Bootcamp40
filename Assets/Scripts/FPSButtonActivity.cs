using UnityEngine;

public class FPSButtonActivity : MonoBehaviour
{
    public GameObject text;
   
    public void fpstext()
    {
        if (text.activeInHierarchy == true)
        {
            PlayerPrefs.SetInt("fpsOn", 0);
            text.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("fpsOn", 1);
            text.SetActive(true);
        }

    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("fpsOn") == 1)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }

    }
}

