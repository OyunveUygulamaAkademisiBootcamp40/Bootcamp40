using UnityEngine;
using UnityEngine.Advertisements;

public class ADsManager : MonoBehaviour
{
#if UNITY_IOS
    string gameID = "4784068";
#else
    string gameID = "4784069";
#endif
    void Start()
    {
        Advertisement.Initialize(gameID);
    }
    public void onClickFiveSec()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }
        
    }
    public void onClickRewarded()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
    }

}
