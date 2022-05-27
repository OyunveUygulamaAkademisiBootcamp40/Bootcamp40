using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSButtonActivity : MonoBehaviour
{
    public GameObject text;

    public void fpstext()
    {
        if (text.activeInHierarchy == true)

            text.SetActive(false);
        else
            text.SetActive(true);


    }
}

