using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;
    private static float ProgressValue = 100.0f;
    [SerializeField]public static float decreasingProgressFactorInTime = .18f;
    [SerializeField]public static float ProgressBarMovingFactor = 20.0f;
    
    void Start()
    {
        progressBar = GetComponent<Slider>();
        progressBar.value = ProgressValue;
    }

    private void FixedUpdate()
    {
       progressBar.value = ProgressValue;
    }


    public void setProgress(float newProgress)
    {
        ProgressValue = newProgress;
    }

    public static void DecreseProgressInTime()
    {
        ProgressValue -= decreasingProgressFactorInTime;
    }

    public void IncreasePogressFromCollectables(float CollectedProgress)
    {
        ProgressValue += CollectedProgress;
    }

    public void DecreaseProgressDueToObstacles(float ObstaclesProgress)
    {
        ProgressValue -= ObstaclesProgress;
    }

    public void MoveRightProgressBar()
    {
        transform.position = new Vector3(transform.position.x + ProgressBarMovingFactor * Time.deltaTime, transform.position.y, transform.position.z);
    }

    public void MoveLeftProgressBar()
    {
        transform.position = new Vector3(transform.position.x - ProgressBarMovingFactor * Time.deltaTime,
            transform.position.y, transform.position.z);
    }


}
