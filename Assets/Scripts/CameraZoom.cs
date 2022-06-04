using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    [SerializeField] public int zoom = 10;
    [SerializeField] public float smooth = 5;

    public bool isZoomed = false;

    public void ZoomEffect()
    {
        if (isZoomed==true)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
    }
}
