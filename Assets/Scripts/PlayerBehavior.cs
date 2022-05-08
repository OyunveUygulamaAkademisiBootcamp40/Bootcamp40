using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float XAxisMovementFactor = 5f;
    [SerializeField] private float ZAxisMovementFactor = 5f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 4f)
        {
            transform.position = new Vector3(transform.position.x + XAxisMovementFactor * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -4f)
        {
            transform.position = new Vector3(transform.position.x - XAxisMovementFactor * Time.deltaTime, transform.position.y, transform.position.z);
        }

        Move();
    }

    void Move()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + ZAxisMovementFactor*Time.deltaTime);
    }

}
