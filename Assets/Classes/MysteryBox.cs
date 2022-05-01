using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    private int _random;
    [SerializeField] GameObject Obstacle;
    [SerializeField] GameObject Camera;
    [SerializeField] GameObject _BloodEffect;

    private void OnTriggerEnter(Collider other)
{

    if (other.gameObject.CompareTag("Player"))
    {
        _random = Random.Range(1, 3);

        if (_random == 1) // if number is equal 1 , frost effect will work 
            {
            Destroy(gameObject);
            Camera.GetComponent<FrostEffect>().enabled = true;
            Obstacle.gameObject.tag = "ineffective";
            Invoke(nameof(BackToNormalFromFrost), 5.0f);

            }
            else // if number is bigger than one, damage effect will work
            {
            Destroy(gameObject);
           _BloodEffect.SetActive(true);
            Invoke(nameof(BackToNormalFromBurn), 5.0f);
        }
    }   
}

   public void BackToNormalFromFrost()
    {
        Camera.GetComponent<FrostEffect>().enabled = false;
        Obstacle.gameObject.tag = "Obstacles";
    }

    public void BackToNormalFromBurn()
    {
        _BloodEffect.SetActive(false);
    }

}