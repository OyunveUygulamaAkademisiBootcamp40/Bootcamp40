
using UnityEngine;


public class MusicButton : MonoBehaviour
{
    public GameObject uiMusicButton;
    private bool isOn;

    public AudioSource audioSource;

    public void buttonClicked()
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("musicOn", 0);
            isOn = false;
            audioSource.mute = true;

        }
        else
        {
            PlayerPrefs.SetInt("musicOn", 1);
            isOn = true;
            audioSource.mute = false;
        }
    }
    private void Start()
    {
        isOn = true;
        if (PlayerPrefs.GetInt("musicOn")==1)
        {
            isOn = true;
        }
        else
        {
            isOn = false;
        }
    }
}