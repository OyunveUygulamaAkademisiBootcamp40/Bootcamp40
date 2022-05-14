using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
   [SerializeField] Animator _anim;
    public Text _coinCountText;
    private float _coinCount;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            _coinCount++;
            _coinCountText.text = _coinCount.ToString();
            TotalScore._totalScore++;
           _anim.SetBool("coinControl", true);
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.4f);
        _anim.SetBool("coinControl", false);
        
    }
}
