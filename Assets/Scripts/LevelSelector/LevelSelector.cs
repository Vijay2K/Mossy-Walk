using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] bool unlocked;
    public Image unlockImage;
    public GameObject[] stars;
    public Sprite starSprite;

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelSelection();
    }

    private void UpdateLevelImage()
    {
        if (!unlocked)
        {
            unlockImage.gameObject.SetActive(true);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false);
                GetComponent<Button>().interactable = false;
            }

        }
        else
        {
            unlockImage.gameObject.SetActive(false);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
                GetComponent<Button>().interactable = true;
            }

            for (int i = 0; i < PlayerPrefs.GetInt("Lv" + gameObject.name); i++)
            {
                stars[i].gameObject.GetComponent<Image>().sprite = starSprite;
            }
        }
    }


    private void UpdateLevelSelection()
    {
        int previousLvl = int.Parse(gameObject.name) - 1;
        if(PlayerPrefs.GetInt("Lv" + previousLvl) > 0)
        {
            unlocked = true;
        }
    }


    public void SelectLevel(string levelName)
    {
        if (unlocked)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
