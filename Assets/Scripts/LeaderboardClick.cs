
using UnityEngine;

public class LeaderboardClick : MonoBehaviour
{
    [SerializeField] GameObject leaderboardCanvas;
    public void onOpenClickLB()
    {
        leaderboardCanvas.SetActive(true);
    }
    public void onCloseClickLB()
    {
        leaderboardCanvas.SetActive(false);
    }
}
