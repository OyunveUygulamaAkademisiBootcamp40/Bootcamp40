using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltingManager : MonoBehaviour
{
    [SerializeField] private float meltingConstant = 10.0f;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        NormalizePlayerPosition();
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseSize();
    }

    void DecreaseSize()
    {
        transform.localScale =
            new Vector3(transform.localScale.x-Time.deltaTime*meltingConstant, transform.localScale.y-Time.deltaTime*meltingConstant, transform.localScale.z-Time.deltaTime*meltingConstant);
    }

    void NormalizePlayerPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.localScale.y / 2, transform.position.z);
    }
    
    //Defeat scene eklendikten sonra defeat behavior yaratilacak
}
