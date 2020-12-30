using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverPanel;    


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        gameOverPanel.SetActive(false);        
    }

    private void Update()
    {
        if (PlayerHealth.Instance.isDead == true)
        {
            SpitPlant.Instance.StopSpawning();
            gameOverPanel.SetActive(true);                       
        }
    }

}
