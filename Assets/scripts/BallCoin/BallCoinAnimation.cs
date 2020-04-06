using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCoinAnimation : MonoBehaviour
{
    float startTime;
    public AudioSource CoinSound;
    private float randomSpeedСoefficient;
    void Start()
    {
        CoinSound = GetComponent<AudioSource>();
        startTime = Time.time;
        CoinSound.clip = Resources.Load<AudioClip>("CoinSound");
        randomSpeedСoefficient = Random.Range(0.5f, 2f);
        PlaySound();
    }
    void Update()
    {
        float t = (Time.time - startTime) / randomSpeedСoefficient;
        transform.position = new Vector3(Mathf.SmoothStep(transform.position.x, GameObject.Find("BallCoin").transform.position.x, t), Mathf.SmoothStep(transform.position.y, GameObject.Find("BallCoin").transform.position.y, t), 0); //плавная анимация вылета
        if((transform.position.x == GameObject.Find("BallCoin").transform.position.x) && (transform.position.y == GameObject.Find("BallCoin").transform.position.y))
        {
            Destroy(gameObject);
        }
    }
    private void PlaySound()
    {
        CoinSound.Play();
    }
}
