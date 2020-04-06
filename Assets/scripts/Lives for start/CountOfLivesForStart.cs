using UnityEngine.UI;
using UnityEngine;

public class CountOfLivesForStart : MonoBehaviour
{
    public static int CountOfLives;
    public Text CountOfLivesText;
    public int isFirstLaunch;
    public GameObject ShopPanel;
    public GameObject PlayButton;
    void Start()
    {
        ShopPanel.gameObject.SetActive(false);
        isFirstLaunch = PlayerPrefs.GetInt("CountOfLaunch");
        if (isFirstLaunch == 0)
        {
            PlayerPrefs.SetInt("CountOfLives", 5);
            CountOfLives = PlayerPrefs.GetInt("CountOfLives");
            Debug.Log("first launch");
            PlayerPrefs.SetInt("CountOfLaunch", 1);
        } else
        {
            CountOfLives = PlayerPrefs.GetInt("CountOfLives");
            Debug.Log("welcome back again");

        }
    }

    void Update()
    {
        CountOfLivesText.text = CountOfLives.ToString();
        if(CountOfLives == 0)
        {
            CountOfLivesText.text = "+";
        }
    }
    public void GetMoreLives()
    {

            if(ShopPanel.gameObject.activeSelf == true)
            {
                ShopPanel.gameObject.SetActive(false);
                PlayButton.gameObject.SetActive(true);

            }
            else
            {
                ShopPanel.gameObject.SetActive(true);
                PlayButton.gameObject.SetActive(false);
            }
        

    }
}
