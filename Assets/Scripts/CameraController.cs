using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject FollowingObject;

    [SerializeField] public float FollowingDistance = 10.0f;

    
    public Camera cam;
    [SerializeField] public int zoom = 10;
    [SerializeField] public float smooth = 5;

    public bool isZoomed = false;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = new Vector3(transform.position.x,transform.position.y ,FollowingObject.transform.position.z - FollowingDistance);
    }

    private void LateUpdate()
    {
        if (isZoomed==true)
        {
            cam.fieldOfView= Mathf.Lerp(cam.fieldOfView, zoom, Time.deltaTime * smooth);
        }
     transform.position = new Vector3( transform.position.x, transform.position.y,FollowingObject.transform.position.z - FollowingDistance);
    }
}
