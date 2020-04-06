using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawn : MonoBehaviour
{
    new Animation animation;
    void Start()
    {
        animation = GetComponent<Animation>();
        animation.Play("SpikeCreating");
    }
}
