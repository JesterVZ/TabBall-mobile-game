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

        }

    }
}
