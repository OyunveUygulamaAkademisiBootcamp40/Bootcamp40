using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class DefeatScene : MonoBehaviour
{
    public bool DefeatSceneIsActive;
    public GameObject defeatScene;
    [SerializeField] public Image filler;
    public int whichLevel;


    void Start()
    {
        whichLevel = SceneManager.playerLevel;
        DefeatSceneIsActive = false;
        filler.GetComponent<Image>();
    }

    void Update()
    {
        if (DefeatSceneIsActive == false)
        {
            if (filler.fillAmount < 0.0026f)
            {
                DefeatSceneIsActive = true;
                defeatScene.SetActive(true);
                DefeatSceneDone();
            }
        }
    }
    void DefeatSceneDone()
    {
        AnalyticsResult analyticsResult = Analytics.CustomEvent("LevelFailed", 
            new Dictionary<string,object> {
                { "Level:",whichLevel},
                {"Position:",Mathf.RoundToInt(transform.position.z/20f) }
            });
            Debug.Log("Sonuc:" + analyticsResult);
            FindObjectOfType<AudioManager>().Play("defeatSound");
  
        StopAllCoroutines();
    }
}

