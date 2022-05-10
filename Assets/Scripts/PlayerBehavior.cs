using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
   protected static bool gameIsStarted = false;
   protected static bool gameIsFinished = false;
   private bool moveLeft = false;
   private bool moveRight = false;
   
   
   
    [SerializeField] private float XAxisMovementFactor = 5f;
    [SerializeField] private float ZAxisMovementFactor = 5f;
    
    InputManager inputManager = new InputManager();
    
    private void Start()
    {
        
    }

    private void Update()
    {
        GetInput();
        
        MoveDirectionZ();
        MoveDirectionX();
    }

    void MoveDirectionZ()
    {
        if (gameIsStarted && !gameIsFinished)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + ZAxisMovementFactor*Time.deltaTime);
        }
    }

    void GetInput()
    {
        if(inputManager.getInput() != 0)
        {
            if (inputManager.getInput() > 0 )
            {
                moveRight = true;
                if (!gameIsStarted)
                    {
                        StartLevel();
                    }
            }
            else if (inputManager.getInput() < 0)
            {
                moveLeft = true;
                if (!gameIsStarted)
                    {
                        StartLevel();
                    }
            }
        }
        else
        {
            moveLeft = false;
            moveRight = false;
        }

        
    }

    void MoveDirectionX()
    {
        if (moveLeft && !gameIsFinished && transform.position.x > -4f)
        {
            transform.position = new Vector3(transform.position.x - XAxisMovementFactor * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (moveRight && !gameIsFinished && transform.position.x < 4f)
        {
            transform.position = new Vector3(transform.position.x + XAxisMovementFactor * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    void EndLevel()
    {
        gameIsFinished = true;
    }

    void StartLevel()
    {
        gameIsStarted = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            EndLevel();
        }
    }
}
