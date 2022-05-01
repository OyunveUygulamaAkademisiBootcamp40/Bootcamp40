using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    // Karakter bu power up ý alýrsa 5 saniye boyunca etrafta buz efekti olacak ve engellerin is trigger özelliði kapanacak ve sörf tahtasýnýn boyu deðiþmeyecek


    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GetComponent<FrostEffect>().enabled = true;
            Invoke(nameof(BackToNormalFromFrost), 5.0f);
        }
    }

    private void BackToNormalFromFrost()
    {
        GetComponent<FrostEffect>().enabled = true;
    }
}
