using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatScene : MonoBehaviour
{
    public bool DefeatSceneIsActive = false;
    public GameObject defeatScene;
    void Start()
    {
        defeatScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DefeatSceneIsActive)
        {
            defeatScene.SetActive(true);
        }
    }
}
