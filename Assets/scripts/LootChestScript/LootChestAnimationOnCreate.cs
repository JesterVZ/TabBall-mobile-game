using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootChestAnimationOnCreate : MonoBehaviour
{
    public GameObject TargerForChest;
    public GameObject CoinAnimateObject;
    public Sprite ChestIsClosed;
    public Sprite ChestIsOpened;
    float startTime;
    private float timer = 0f;
    private bool canDestroy = false;
    private void Start()
    {

        gameObject.GetComponent<Image>().sprite = ChestIsClosed;
        TargerForChest = GameObject.FindGameObjectWithTag("target");
        startTime = Time.time;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if (canDestroy)
            {
                Destroy(gameObject);

            }
        }
        float t = (Time.time - startTime) / 0.4f;
        transform.position = new Vector3(TargerForChest.transform.position.x, Mathf.SmoothStep(TargerForChest.transform.position.y, GameObject.FindGameObjectWithTag("canvas").transform.position.y, t), 0); //плавная анимация вылета
        
    }
    public void GetCoins()
    {
        gameObject.GetComponent<Image>().sprite = ChestIsOpened;
        timer = 1f;
        int random = Random.Range(1, 4);
        GameObject[] coins = new GameObject[random];

        for (int i = 0; i < random; i++)
        {
            Instantiate(CoinAnimateObject, new Vector3(transform.position.x + UnityEngine.Random.Range(10, 50), transform.position.y + +UnityEngine.Random.Range(10, 50), transform.position.z), Quaternion.identity);
        }
        coins = GameObject.FindGameObjectsWithTag("ballCoin");
        for (int i = 0; i < random; i++)
        {
            coins[i].transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, true);
        }
        canDestroy = true;

        int rand = PlayerPrefs.GetInt("Coins") + random;
        LootChestOpenController.TotalCountOfCoins = rand;
        PlayerPrefs.SetInt("Coins", LootChestOpenController.TotalCountOfCoins);
        LootChestOpen.canOpen = true;
    }
}
