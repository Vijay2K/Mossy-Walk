using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarHandler : MonoBehaviour
{
    public static StarHandler Instance;

    [SerializeField] GameObject[] stars;
    private int gemCount;
    public int levelIndex;

    public int starCount = 0;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        gemCount = GameObject.FindGameObjectsWithTag("gems").Length;
    }


    private void Update()
    {
        if(starCount > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, starCount);
        }
    }

    public void StarAcheived()
    {
        int gemLeft = GameObject.FindGameObjectsWithTag("gems").Length;
        int gemCollected = gemCount - gemLeft;

        float collectPercent = float.Parse(gemCollected.ToString()) / float.Parse(gemCount.ToString()) * 100f;

        if(collectPercent >= 0f && collectPercent < 66f)
        {
            stars[0].SetActive(true);
            starCount = 1;
        }

        else if(collectPercent >= 66 && collectPercent < 70)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);

            starCount = 2;
        }
        else
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);

            starCount = 3;
        }
    }
}
