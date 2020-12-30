using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    public static AdsManager Instance;    

    private string GooglePlay_ID = "3840297";
    bool testGameMode = false;

   

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Advertisement.Initialize(GooglePlay_ID, testGameMode);
       
    }

    public void DisplayInterstitialAds()
    {
        Advertisement.Show();
    }   
      
}
