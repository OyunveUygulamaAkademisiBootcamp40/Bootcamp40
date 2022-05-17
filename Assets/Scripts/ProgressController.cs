using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : FreezingProgress
{
    
    [SerializeField]public static float ProgressBarMovingFactor = 20.0f;
    
    private void Start()
    {
        
    }
    
    
   

    public void IncreasePogressFromCollectables(float CollectedProgress)
    {
        //progress += CollectedProgress;
    }

    public void DecreaseProgressDueToObstacles(float ObstaclesProgress)
    {
        //progress -= ObstaclesProgress;
    }

    /*public void MoveRightProgressBar()
    {
        transform.position = new Vector3(transform.position.x + ProgressBarMovingFactor * Time.deltaTime, transform.position.y, transform.position.z);
    }

    public void MoveLeftProgressBar()
    {
        transform.position = new Vector3(transform.position.x - ProgressBarMovingFactor * Time.deltaTime,
            transform.position.y, transform.position.z);
    }
    */

}
