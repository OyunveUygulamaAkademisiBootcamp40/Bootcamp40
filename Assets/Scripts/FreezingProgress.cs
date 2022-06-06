using UnityEngine;
using UnityEngine.UI;

public class FreezingProgress : MonoBehaviour
{
    public static float progress = 1000.0f;
    public Image fill;
    

    

    protected void setProgress(float newProgress)
    {
        progress = newProgress;
    }

    public static float getProgress()
    {
        return progress;
    }
}
