using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUIMaker : MonoBehaviour
{
    // Start is called before the first frame update

    public Text LevelUIStartText;
    public Text LevelUIEndText;
    private static int playerLevel;
    void Start()
    {
        playerLevel = SceneManager.playerLevel;
        LevelUIStartText.text  = playerLevel.ToString();
        LevelUIEndText.text = (playerLevel + 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
