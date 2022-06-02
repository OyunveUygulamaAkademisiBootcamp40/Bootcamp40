using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject coinUIPrefeab;

    public Text _coinCountText;
    private float _coinCount;

    public void Update()
    {
        panel = GameObject.FindGameObjectWithTag("CoinBar");
        _coinCountText.text = TotalScore._totalScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            FindObjectOfType<AudioManager>().Play("coinSound");
            Destroy(other.gameObject);
            Instantiate(coinUIPrefeab, _camera.WorldToScreenPoint(transform.position), panel.transform.rotation, panel.transform);
            TotalScore._totalScore++;
        }
    }
}
