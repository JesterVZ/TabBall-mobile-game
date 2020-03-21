using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    private bool IsMute = false;
    public Sprite spriteVolume;
    public Sprite spriteMute;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SoundsControl()
    {

        IsMute = !IsMute;
        switch (IsMute)
        {
            case true:
                gameObject.GetComponent<Image>().sprite = spriteMute;
                AudioListener.volume = 0;
                break;
            case false:
                gameObject.GetComponent<Image>().sprite = spriteVolume;
                AudioListener.volume = 1;

                break;
        }

    }
}
