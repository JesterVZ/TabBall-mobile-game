using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsImageRotating : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
