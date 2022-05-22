using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class FinishLine : MonoBehaviour
{
    [SerializeField] public GameObject victoryScene;
    [SerializeField] public GameObject particles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {   
            particles.SetActive(true);
            Invoke("LoadVictoryScene()",5f);
            Debug.Log("triggered");
        }
    }

    void LoadVictoryScene()
    {
        victoryScene.SetActive(true);
    }
}

