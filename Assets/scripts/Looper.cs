using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looper : MonoBehaviour
{
    private float Timer;
    public GameObject Spike;
    private void Start()
    {
        Timer = Random.Range(1f, 5f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 pos = collision.transform.position;
        switch (collision.gameObject.tag)
        {
            case "Ground":
                pos.x += 6;
                collision.transform.position = pos;
                break;
            case "spike":
                Destroy(collision.gameObject);
                break;

        }

    }

}
