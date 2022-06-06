
using UnityEngine;

public class SnowFlake : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("snowFlakeSound");  
            Player.isFrostEffectActive = true;
            Destroy(gameObject);
        }
    }
}
