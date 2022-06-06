
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressUI : MonoBehaviour
{
    [Header("UI references :")]
    [SerializeField] private Image uiFillImage;
 
    [Header("Player & Endline references :")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform endLineTransform;

    private Vector3 endLinePosition;

    private float fullDistance;

    private void Start()
    {
        endLinePosition = endLineTransform.position;
        fullDistance = GetDistance();
        uiFillImage.fillAmount = 0.25f;
    }

    private float GetDistance()
    {
        return (endLinePosition - playerTransform.position).sqrMagnitude;
    }

    private void UpdateProgressFill(float value)
    {
        uiFillImage.fillAmount = value * 0.75f + 0.25f;
    }

    private void Update()
    {
        if (playerTransform.position.z <= endLinePosition.z)
        {
            float newDistance = GetDistance();
            float progressValue = Mathf.InverseLerp(fullDistance + 100f  , 0f, newDistance);

            UpdateProgressFill(progressValue);
        }
    }
}
