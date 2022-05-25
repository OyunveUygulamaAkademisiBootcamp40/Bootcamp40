using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatScene : MonoBehaviour
{
    public bool DefeatSceneIsActive = false;
    public GameObject defeatScene;
    [SerializeField]public Image filler;
  
    
    
    void Start()
    {
        DefeatSceneIsActive = false;
        filler.GetComponent<Image>();
        
    }
 
    void Update()
    {     
        if (filler.fillAmount < 0.0026f)
        {
           Debug.Log("acaba");
           DefeatSceneIsActive = true;
        }

        

        if (DefeatSceneIsActive)
        {
            defeatScene.SetActive(true);
            FindObjectOfType<AudioManager>().Play("defeatSound");
            
        }
    }
}
