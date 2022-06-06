
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioListener audioListener;
    public List<AudioSource> audioSources;

    private bool isOn = true;

    public void ButtonClick()
    {
        if (isOn)
        {
            isOn = false;
            audioListener.enabled = false;
        }
        else
        {
            isOn = true;
            audioListener.enabled = true;
        }
    }

}
