using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTransform : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 15f;

    CoinMoveToMagnetic coinMoveScript;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMoveScript = gameObject.GetComponent<CoinMoveToMagnetic>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CoinDetector"))
        {
            coinMoveScript.enabled = true;
        }
    }
}
