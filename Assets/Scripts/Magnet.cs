using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject coinAreaOBJ;
    void Start()
    {
        coinAreaOBJ = GameObject.FindGameObjectWithTag("CoinDetector");
        coinAreaOBJ.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Magnet")
        {
            StartCoroutine(ActivateCoin());
            Destroy(other.gameObject);
        }
    }
    IEnumerator ActivateCoin()
    {
        coinAreaOBJ.SetActive(true);
        yield return new WaitForSeconds(5f);
        coinAreaOBJ.SetActive(false);
    }
}
