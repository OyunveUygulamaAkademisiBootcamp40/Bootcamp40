using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    private void Awake()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        Invoke(nameof(DestroyStartTransition), 2.3f);
    }

    public void DestroyStartTransition()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
