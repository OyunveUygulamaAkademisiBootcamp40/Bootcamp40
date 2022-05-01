using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    private int _random;

   /* [SerializeField] private GameObject _Obstacle;
    [SerializeField] private GameObject _Camera;
    [SerializeField] private GameObject _blood;*/

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            _random = Random.Range(1, 3);

            if (_random == 1) // if number is equal 1 , frost effect will work 
            {
               Destroy(gameObject);


            //   _Camera.GetComponent<FrostEffect>().enabled = true;
              //  _Obstacle.gameObject.tag = "ineffective";  // 
              //  Invoke(nameof(BackToNormalFromFrost), 5.0f);

            }
            else // if number is bigger than one, damage effect will work
            {
                Destroy(gameObject);

               
               // _blood.SetActive(true);
               // Invoke(nameof(BackToNormalFromBurn), 5.0f);
            }
        }
    }


    private void BackToNormalFromFrost()
    {
       // _Camera.GetComponent<FrostEffect>().enabled = false;
       // _tes2.gameObject.tag = "Obstacles";
    }

    private void BackToNormalFromBurn()
    {
      //  _blood.SetActive(false);
        //  will be added to affect character health
    }
}
