using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject FollowingObject;

    [SerializeField] public float FollowingDistance = 10.0f;

    public CameraZoom cameraZoom;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cameraZoom.GetComponent<CameraZoom>();
    transform.position = new Vector3(transform.position.x,transform.position.y ,FollowingObject.transform.position.z - FollowingDistance);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void LateUpdate()
    {
        if (cameraZoom.isZoomed==true)
        {
            cam.fieldOfView= Mathf.Lerp(cam.fieldOfView, cameraZoom.zoom, Time.deltaTime * cameraZoom.smooth);
        }
        transform.position = new Vector3( transform.position.x, transform.position.y,FollowingObject.transform.position.z - FollowingDistance);
    }
}
