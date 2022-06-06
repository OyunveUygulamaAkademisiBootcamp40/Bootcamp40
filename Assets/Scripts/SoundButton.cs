
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioListener audioListener;
    public List<AudioSource> audioSources;

    private bool isOn;

    public void ButtonClick()
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("soundOn", 0);
            isOn = false;
            audioListener.enabled = false;
        }
        else
        {
            PlayerPrefs.SetInt("soundOn", 1);
            isOn = true;
            audioListener.enabled = true;

        }
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("soundOn") == 1)
        {
            isOn = true;
        }
        else
        {
            isOn = false;
        }

    }
}
