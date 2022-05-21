using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Player : ProgressController
{
    public GameObject _tutorialManger;
    public static bool gameIsStarted = false;
    public static bool gameIsFinished = false;
    private bool moveLeft = false;
    private bool moveRight = false;
    [SerializeField] private float XAxisMovementFactor = 5f;
    [SerializeField] private float ZAxisMovementFactor = 5f;

    public static float decreasingProgressFactorInTime = 2.0f;
    
    InputManager inputManager = new InputManager();
    

   public Slider slider;

    private void Start()
    {
        _tutorialManger.SetActive(true);
        progress = 1000.0f;
        setSliderValue();
    }

    private void FixedUpdate()
    {   
        setSliderValue();
        if (gameIsStarted && !gameIsFinished)
        {
            DecreseProgressInTime();
        }
    }
    
    private void Update()
    {   
        
        
        
        MoveDirectionZ();
        MoveDirectionX();
        //MoveProgressBar(); Todo(baris)
        GetInput();
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
        else if (other.tag == "SnowFlake")
        {
            progress += 300.0f;
        }
        else if (other.tag == "SnowCanon")
        {
            progress += 500.0f;
        }
        else if (other.tag == "FlameCannon")
        {
            progress -= 100.0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Lava")
        {
            progress -= 2 * decreasingProgressFactorInTime;
        }
    }

    void MoveProgressBar()
    {

    }
    
    private void setSliderValue()
    {
        slider.value = progress;
    }
    protected void DecreseProgressInTime()
    {
        progress -= decreasingProgressFactorInTime;
    }

    
}
