using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MeltingBehavior : MonoBehaviour
{
    [SerializeField] public float meltingConstant = 10.0f;

    private bool DecreasingState = false;
    private float FirstScaleY;

    private static float progressInMelting;
        // Start is called before the first frame update
    void Start()
    {
        FirstScaleY = transform.localScale.y;
    }

    private void FixedUpdate()
    {
        progressInMelting = FreezingProgress.getProgress();
        DecreaseBoardScaleAcordingToProgress(progressInMelting);
        NormalizePlayerPosition();
        
    }
    
    void NormalizePlayerPosition()
    {
       transform.position = new Vector3(transform.position.x, transform.localScale.y / 2, transform.position.z);
    }

    public void DecreaseBoardScaleAcordingToProgress(float progress)
    {
        if (progress > 999)
        {
            transform.localScale =
                new Vector3(transform.localScale.x, FirstScaleY, transform.localScale.z);
        }
        else if (progress < 1)
        {
            transform.localScale =
                new Vector3(transform.localScale.x, 0 , transform.localScale.z);
            gameObject.SetActive(false);
            Player.gameIsFinished = true;
        }
        else
        {
            float newLocalScaleY = progress * (FirstScaleY) / 1000f;
            transform.localScale =
                new Vector3(transform.localScale.x, newLocalScaleY , transform.localScale.z);
        }
    }


    //Defeat scene eklendikten sonra defeat behavior yaratilacak
}
