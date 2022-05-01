using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public PathCreation.PathCreator pathCreator;
    public PathCreation.EndOfPathInstruction end;
    [SerializeField] public float speed = 10.0f;
    float dstTravelled;
    void Update()
    {
        MoveonDirectionZ();
    }

    void MoveonDirectionZ()
    {
        dstTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end) + new Vector3(0,transform.localScale.y / 2.0f ,0);
        transform.rotation = pathCreator.path.GetRotationAtDistance(dstTravelled, end);
    }

}
