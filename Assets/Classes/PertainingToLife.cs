using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PertainingToLife : MonoBehaviour
{

    // Karakter bunlarý topladýðý sürece hayatta kalabilecek 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
