using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreezingProgress : MonoBehaviour
{
    protected float progress = 100.0f;
    public Image fill;
    

    

    protected void setProgress(float newProgress)
    {
        progress = newProgress;
    }

    protected float getProgress()
    {
        return progress;
    }
}
