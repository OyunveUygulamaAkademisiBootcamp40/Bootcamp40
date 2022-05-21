using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveToMagnetic : MonoBehaviour
{
    CoinTransform coinTransformScript;
    void Start()
    {
        coinTransformScript = gameObject.GetComponent<CoinTransform>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, coinTransformScript.playerTransform.position, coinTransformScript.moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
