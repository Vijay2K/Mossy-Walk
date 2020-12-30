using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMuteSystem : MonoBehaviour 
{
    [SerializeField] Button musicTogglerButton;
    [SerializeField] Sprite onButton;
    [SerializeField] Sprite offButton;

    private void Start()
    {
        UpdateIcon();
    }


    private void Update()
    {
        
    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
           // AudioListener.volume = 1;
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
           // AudioListener.volume = 0;
        }
    } 

    public void PauseMusic()
    {
        ToggleSound();
        UpdateIcon();
    }

    public void UpdateIcon()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicTogglerButton.GetComponent<Image>().sprite = onButton;
        }

        else
        {
            AudioListener.volume = 0;
            musicTogglerButton.GetComponent<Image>().sprite = offButton;

        }
    }
}
