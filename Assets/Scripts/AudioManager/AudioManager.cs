using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip jumpSound;
    public AudioClip coinPickSound;
    public AudioClip gemPickSound;
    public AudioClip keyPicksound;   
    public AudioClip jumpPlantSound;
    public AudioClip damageSound;
    public AudioClip chestLockSound;
    public AudioClip WinningSound;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }  

}
