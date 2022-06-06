
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
        if (playerLevel != 0)
        {
            LevelUIStartText.text  = playerLevel.ToString();
            LevelUIEndText.text = (playerLevel + 1).ToString();
        }
        else
        {
            LevelUIStartText.text = "";
            LevelUIEndText.text = (playerLevel + 1).ToString();
        }

        
    }

}
