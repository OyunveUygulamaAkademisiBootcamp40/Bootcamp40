using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject _tutorialManger;
    public static bool gameIsStarted = false;
    public static bool gameIsFinished = false;
    private bool moveLeft = false;
    private bool moveRight = false;
    private ProgressBar _progressBar = new ProgressBar();
    [SerializeField] private float XAxisMovementFactor = 5f;
    [SerializeField] private float ZAxisMovementFactor = 5f;

    InputManager inputManager = new InputManager();

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        GetInput();
    }

    private void Update()
    {


        MoveDirectionZ();
        MoveDirectionX();
        MoveProgressBar();

    }

    void MoveDirectionZ()
    {
        if (gameIsStarted && !gameIsFinished)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                transform.position.z + ZAxisMovementFactor * Time.deltaTime);
            _tutorialManger.SetActive(false);
        }
    }

    void GetInput()
    {
        if (inputManager.getInput() > 0.0f)
        {
            moveRight = true;
            moveLeft = false;

            if (!gameIsStarted)
            {
                StartLevel();
            }

        }
        else if (inputManager.getInput() < 0.0f)
        {
            moveLeft = true;
            moveRight = false;

            if (!gameIsStarted)
            {
                StartLevel();
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
            transform.position = new Vector3(transform.position.x - XAxisMovementFactor * Time.deltaTime,
                transform.position.y, transform.position.z);
            _tutorialManger.SetActive(false);
        }

        if (moveRight && !gameIsFinished && transform.position.x < 4f)
        {
            transform.position = new Vector3(transform.position.x + XAxisMovementFactor * Time.deltaTime,
                transform.position.y, transform.position.z);
            _tutorialManger.SetActive(false);
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

    void MoveProgressBar()
    {

    }



}
