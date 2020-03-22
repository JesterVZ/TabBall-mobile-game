using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    private float speed;
    private float Timer;
    private float JumpForce = 350f;
    private bool IsGround = false;
    private int CountOfJumps;

    AudioSource getItemSound;

    new Rigidbody2D rigidbody;
    new Animation animation;
    public GameObject GameOverPanel;
    public GameObject PausePanel;
    public Text TotalScore;
    public Text TotalBestScore;
    public Transform groundCheck;

    public float CheckRadius;
    public LayerMask WhatIsGround;
    void Start()
    {
        Timer = 5f;
        Time.timeScale = 1;
        speed = 2f;
        CountOfJumps = 1;
        ScoreSystem.CountOfLifes = 2;
        GameOverPanel.gameObject.SetActive(false);
        PausePanel.gameObject.SetActive(false);
        rigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animation>();
        getItemSound = GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        IsGround = Physics2D.OverlapCircle(groundCheck.position, CheckRadius, WhatIsGround);
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            speed += 0.2f;
            Timer = 5f;
        }
            if (Input.GetKeyDown(KeyCode.A))
        {
            Jump();
        }
        for(int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Jump();
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "spike":
                if(ScoreSystem.CountOfLifes == 1)
                {
                    ScoreSystem.CountOfLifes--;
                    Time.timeScale = 0;
                    CheckResults();
                } else
                {
                    Destroy(collision.gameObject);
                    animation.Play("PlayerIsGetDamage");
                    ScoreSystem.CountOfLifes--;
                }
                break;
            case "AddScore":
                ScoreSystem.scoreValue++;
                break;
            case "bonus":
                ScoreSystem.scoreValue = ScoreSystem.scoreValue + Random.Range(2, 6);
                animation.Play("PlayerGetItem");
                Destroy(collision.gameObject);
                getItemSound.Play(0);
                break;
            case "life":
                ScoreSystem.CountOfLifes++;
                animation.Play("PlayerGetItem");
                Destroy(collision.gameObject);
                getItemSound.Play(0);
                break;
        }
    }
    public void Jump()
    {
        if(IsGround == true || CountOfJumps > 0)
        {
            //rigidbody.AddForce(transform.up * JumpForce);
            rigidbody.velocity = Vector2.up * JumpForce/55;
            CountOfJumps--;
        }
        if(CountOfJumps <= 0 && IsGround == true)
        {
            CountOfJumps = 1;
        }
    }
    private void CheckResults()
    {
        if(ScoreSystem.scoreValue > ScoreSystem.bestScoreValue)
        {
            ScoreSystem.bestScoreValue = ScoreSystem.scoreValue;
            PlayerPrefs.SetInt("BestScore", ScoreSystem.bestScoreValue);
        }
        GameOverPanel.gameObject.SetActive(true);
        TotalScore.text = "You Score: " + ScoreSystem.scoreValue;
        TotalBestScore.text = "You best score: " + ScoreSystem.bestScoreValue;
    }

    public void PauseGame()
    {
        if(Time.timeScale == 1)
        {
            PausePanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.gameObject.SetActive(false);
        GameOverPanel.gameObject.SetActive(false);
    }
}