using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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