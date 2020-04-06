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
        int soundState = PlayerPrefs.GetInt("volume");
        switch (soundState)
        {
            case 0:
                gameObject.GetComponent<Image>().sprite = spriteMute;
                AudioListener.volume = 0;
                break;
            case 1:
                gameObject.GetComponent<Image>().sprite = spriteVolume;
                AudioListener.volume = 1;
                break;
        }
    }

    public void SoundsControl()
    {

        IsMute = !IsMute;
        switch (IsMute)
        {
            case true:
                gameObject.GetComponent<Image>().sprite = spriteMute;
                AudioListener.volume = 0;
                PlayerPrefs.SetInt("volume", 0);
                break;
            case false:
                gameObject.GetComponent<Image>().sprite = spriteVolume;
                AudioListener.volume = 1;
                PlayerPrefs.SetInt("volume", 1);
                break;
        }

    }
}
