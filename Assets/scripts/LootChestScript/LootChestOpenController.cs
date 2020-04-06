using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootChestOpenController : MonoBehaviour
{
    public static int TotalCountOfCoins;
    public Text CountOfCoinsText;
    private void Start()
    {
        TotalCountOfCoins = PlayerPrefs.GetInt("Coins");
    }
    private void Update()
    {
        CountOfCoinsText.text = TotalCountOfCoins.ToString();
    }
}
