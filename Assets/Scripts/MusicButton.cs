
using UnityEngine;


public class MusicButton : MonoBehaviour
{
    public GameObject uiMusicButton;
    private bool isOn = true;

    public AudioSource audioSource;


    public void buttonClicked()
    {
        if (isOn)
        {
            isOn = false;
            audioSource.mute = true;

        }
        else
        {
            isOn = true;
            audioSource.mute = false;
        }
    }
}