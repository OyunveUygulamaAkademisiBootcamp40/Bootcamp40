using System;
using UnityEngine;
using UnityEngine.UI;



public class Player : ProgressController
{
    public GameObject meltingParticle;
    public GameObject _tutorialManger;
    public static bool gameIsStarted = false;
    public static bool gameIsFinished = false;
    private bool moveLeft = false;
    private bool moveRight = false;
    [SerializeField] private float XAxisMovementFactor = 5f;
    [SerializeField] private float ZAxisMovementFactor = 5f;

    public static float decreasingProgressFactorInTime = 1.0f;
    
    InputManager inputManager = new InputManager();

    public static bool isFrostEffectActive = false;
    public static bool isFlameEffectActive = false;


    private float inputOldPos = 0.0f;
    private float inputNewPos = 0.0f;
    

   public Slider slider;

    private void Start()
    {
        if (SceneManager.playerLevel==1)
        {
            _tutorialManger.SetActive(true);
        }
        else
        {
            _tutorialManger.SetActive(false);
        }
        
        progress = 1000.0f;
        setSliderValue();
        gameIsFinished = false;
        gameIsStarted = false;
    }

    private void FixedUpdate()
    {   
        checkProgressExceedFull();
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
        inputNewPos = Input.mousePosition.x;
        
        if(Math.Abs(inputNewPos - inputOldPos) > 3.0f && Input.GetMouseButton(0))
        {
            if (inputNewPos - inputOldPos > 0.0f)
            {
                moveRight = true;
                moveLeft = false;

                if (!gameIsStarted)
                {   
                    StartLevel();
                }

            }
            else if (inputNewPos - inputOldPos < 0.0f)
            {
                moveLeft = true;
                moveRight = false;

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
        inputOldPos = inputNewPos;
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
        meltingParticle.SetActive(false);
    }

    void StartLevel()
    {
        gameIsStarted = true;
        meltingParticle.SetActive(true);
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
            FindObjectOfType<AudioManager>().Play("snowCannonSound");
            progress += 500.0f;
        }
        else if (other.tag == "FlameCannon")
        {
            FindObjectOfType<AudioManager>().Play("flameCannonSound");
            progress -= 300.0f;
        }
        else if (other.tag == "Lava")
        {
            FindObjectOfType<AudioManager>().Play("flameCannonSound");
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

    void checkProgressExceedFull()
    {
        if (progress > 1000.0f)
        {
            progress = 1000.0f;
        }
    }


}
