using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinMoveAnimation : MonoBehaviour
{
    Transform panel;
    Sequence goldAnimation;
    Rigidbody2D rgd;

    void Start()
    {
        AnimasyonHazirla();
    }

    void AnimasyonHazirla()
    {
        rgd = GetComponent<Rigidbody2D>();
        panel = GameObject.FindGameObjectWithTag("CoinUI").transform;
        goldAnimation = DOTween.Sequence();

        goldAnimation.Append(transform.DOMove(panel.position, 1)
            .SetEase(Ease.OutSine))
            .OnComplete(() => Destroy(gameObject));
    }

}
