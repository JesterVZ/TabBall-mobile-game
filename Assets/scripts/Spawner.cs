using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float Timer;
    private int IndexOfItem;
    public GameObject[] Items;
    private void Start()
    {
        Timer = Random.Range(0.01f, 0.1f);
    }
    private void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {

            Timer = Random.Range(0.5f, 2f);
            IndexOfItem = Random.Range(0, Items.Length);
            Instantiate(Items[IndexOfItem], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            /*  if (Items[IndexOfItem].tag == "life")
              {
                  if(SettingsController.CanSpawnLives == true)
                  {
                      Instantiate(Items[IndexOfItem], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                  } else
                  {
                      Instantiate(Items[IndexOfItem+1], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                  }
              } else
              {
                  Instantiate(Items[IndexOfItem], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
              }


              if((SettingsController.CanSpawnLives == true && Items[IndexOfItem].tag == "life") || (SettingsController.CanSpawnBonus == true && Items[IndexOfItem].tag == "bonus"))
              {
                  Instantiate(Items[IndexOfItem], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

              } else
              {
                  if(IndexOfItem == Items.Length - 1)
                  {
                      Instantiate(Items[IndexOfItem], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

                  } else
                  {
                      Instantiate(Items[IndexOfItem + 1], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                  }

              }*/

        }

    }
}
