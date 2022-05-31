using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScaler : MonoBehaviour
{
    public GameObject SurfBorad;

    public GameObject PlayerCharacter;
    // Start is called before the first frame update
    private Vector3 vector3position;
    private float progress;
    private Vector3 vector3scale;
    private float FirstScaleX;
    private float FirstScaleY;
    private float FirstScaleZ;
    void Start()
    {
        FirstScaleX = PlayerCharacter.transform.localScale.x;
        FirstScaleY = PlayerCharacter.transform.localScale.y;
        FirstScaleZ = PlayerCharacter.transform.localScale.z;
        
        vector3position = SurfBorad.transform.position;
        PlayerCharacter.transform.position = vector3position + new Vector3(0,0,0 );
    }

    private void FixedUpdate()
    {
        progress = Player.progress;
        ArangeCharacterScaleAccordingToProgress(progress);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        vector3position = SurfBorad.transform.position;
        PlayerCharacter.transform.position = vector3position + new Vector3(0,0 ,0 );
        
    }

    void ArangeCharacterScaleAccordingToProgress(float progress)
    {
        {
            if (progress > 999)
            {
                transform.localScale = new Vector3(FirstScaleX,FirstScaleY,FirstScaleZ );
            }
            else if (progress < 1)
            {
                transform.localScale = Vector3.zero;
            }
            else
            {
                float newLocalScaleX = progress * (FirstScaleX) / 1000f;
                float newLocalScaleY = progress * (FirstScaleY) / 1000f;
                float newLocalScaleZ = progress * (FirstScaleZ) / 1000f;
                transform.localScale =
                    new Vector3(newLocalScaleX, newLocalScaleY , newLocalScaleZ);
            }
        }
    }
}
