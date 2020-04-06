using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public static int scoreValue, bestScoreValue;
    public static int CountOfLifes;
    public Text scoreText;
    public Text CountOfLifesText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreValue = 0;
        bestScoreValue = PlayerPrefs.GetInt("BestScore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreValue.ToString();
        CountOfLifesText.text = CountOfLifes.ToString();
    }
}
