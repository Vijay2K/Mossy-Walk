using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;

    [SerializeField] Animator transtitions;
    [SerializeField] float transtitionTime = 1f;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void StartAnim(int tran)
    {
        StartCoroutine(LoadLvls(tran));
    }

    IEnumerator LoadLvls(int levelIndex)
    {
        AdsManager.Instance.DisplayInterstitialAds();

        yield return new WaitForSeconds(2);

        transtitions.SetTrigger("Start");

        yield return new WaitForSeconds(transtitionTime);
        
        SceneManager.LoadScene(levelIndex);
    }
}
