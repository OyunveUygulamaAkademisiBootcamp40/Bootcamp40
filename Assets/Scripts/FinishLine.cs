using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class FinishLine : MonoBehaviour
{
    [SerializeField] public GameObject _finishLineCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _finishLineCanvas.SetActive(true);
            Debug.Log("triggered");
        }
    }
}

