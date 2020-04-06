using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    private int price, count;

    public void BuyFiveLives()
    {
        price = 2;
        count = 5;
        if ((LootChestOpenController.TotalCountOfCoins - price) >= 0)
        {
            PlayerPrefs.SetInt("CountOfLives", PlayerPrefs.GetInt("CountOfLives") + count);
            CountOfLivesForStart.CountOfLives = PlayerPrefs.GetInt("CountOfLives");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - price);
            LootChestOpenController.TotalCountOfCoins = PlayerPrefs.GetInt("Coins");
            Debug.Log("buy successful");
        }


    }
    public void BuyTenLives()
    {
        price = 4;
        count = 10;
        if ((LootChestOpenController.TotalCountOfCoins - price) >= 0)
        {
            PlayerPrefs.SetInt("CountOfLives", PlayerPrefs.GetInt("CountOfLives") + 10);
            CountOfLivesForStart.CountOfLives = PlayerPrefs.GetInt("CountOfLives");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 4);
            LootChestOpenController.TotalCountOfCoins = PlayerPrefs.GetInt("Coins");
            Debug.Log("buy successful");
        }


    }
    public void BuyTwentyLives()
    {
        price = 8;
        count = 20;
        if ((LootChestOpenController.TotalCountOfCoins - price) >= 0)
        {
            PlayerPrefs.SetInt("CountOfLives", PlayerPrefs.GetInt("CountOfLives") + 20);
            CountOfLivesForStart.CountOfLives = PlayerPrefs.GetInt("CountOfLives");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 8);
            LootChestOpenController.TotalCountOfCoins = PlayerPrefs.GetInt("Coins");
            Debug.Log("buy successful");
        }


    }
}
