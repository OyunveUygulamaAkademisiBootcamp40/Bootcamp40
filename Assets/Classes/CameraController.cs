using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject FollowingObject;

    [SerializeField] public float FollowingDistance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    transform.position = new Vector3(transform.position.x,transform.position.y ,FollowingObject.transform.position.z - FollowingDistance);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void LateUpdate()
    {
        transform.position = new Vector3( transform.position.x, transform.position.y,FollowingObject.transform.position.z - FollowingDistance);
    }
}
