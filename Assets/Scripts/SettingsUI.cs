using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button FpsButton;
    [SerializeField] private Button SoundButton;
    [SerializeField] private Button MusicButton;
    [SerializeField] private Button LeaderBoardButton;

    public void ButtonClicked()
    {
        if (FpsButton.gameObject.activeInHierarchy == false)
        {
            FpsButton.gameObject.SetActive(true);
            SoundButton.gameObject.SetActive(true);
            MusicButton.gameObject.SetActive(true);
            LeaderBoardButton.gameObject.SetActive(true);
        }

        else if (FpsButton.gameObject.activeInHierarchy == true)
        {
            LeaderBoardButton.gameObject.SetActive(false);
            FpsButton.gameObject.SetActive(false);
            SoundButton.gameObject.SetActive(false);
            MusicButton.gameObject.SetActive(false);
        }

    }
}

