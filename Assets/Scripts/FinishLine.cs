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
            FindObjectOfType<AudioManager>().Play("victorySound");
            particles.SetActive(true);
            Invoke("LoadVictoryScene",5f);
           
        }
    }

    void LoadVictoryScene()
    {
        victoryScene.SetActive(true);
    }
}

