using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountOfCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            TotalAmountOfCoin._totalScore++;
        }
    }
}
