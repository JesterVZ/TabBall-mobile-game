using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootChestController : MonoBehaviour
{
    public static int CountOfChests;
    public Text CountOfChestsText;
    private void Start()
    {
        //PlayerPrefs.SetInt("Coins", 0);
        //PlayerPrefs.SetInt("CountOfChests", 30);
        CountOfChests = PlayerPrefs.GetInt("CountOfChests");
    }
    private void Update()
    {
        CountOfChestsText.text = CountOfChests.ToString();
    }
}
