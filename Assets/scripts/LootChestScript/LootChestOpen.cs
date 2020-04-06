using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootChestOpen : MonoBehaviour
{
    new Animation animation;
    public GameObject lootChestImage;
    public Transform CanvasParent;
    public Transform TargerForChest;
    public static bool canOpen;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        if (PlayerPrefs.GetInt("CountOfChests") != 0)
        {
            animation.Play("ChestHaveCoins");
            canOpen = true;
        } else
        {
            canOpen = false;
        }
    }
    private void Update()
    {
        if (GameObject.Find("LootChestImage(Clone)") != null)
        {
            canOpen = false;
        }
        else
        {
            canOpen = true;
        }
        if(LootChestController.CountOfChests == 0)
        {
            animation.Play("ChestIdle");

        }
    }
    public void OpenChest()
    {
        if (canOpen && LootChestController.CountOfChests != 0)
        {
            LootChestController.CountOfChests--;
            PlayerPrefs.SetInt("CountOfChests", LootChestController.CountOfChests);
            Instantiate(lootChestImage, new Vector3(TargerForChest.transform.position.x, TargerForChest.transform.position.y, TargerForChest.transform.position.z), Quaternion.identity);
            GameObject.Find("LootChestImage(Clone)").transform.SetParent(CanvasParent.transform, true);
            canOpen = false;
        }
    }
    
}
