using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    [SerializeField] GameObject openedChest;
    [SerializeField] GameObject closedChest;
    [SerializeField] GameObject warningMsg;
    [SerializeField] GameObject levelCompletePanel;
    AudioSource audioSource;

    bool isOpened;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        closedChest.SetActive(true);
        openedChest.SetActive(false);
        warningMsg.SetActive(false);
        levelCompletePanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if(col.gameObject.GetComponent<Collectors>().keyCount == 1)
            {
                openedChest.SetActive(true);
                closedChest.SetActive(false);
                isOpened = true;
                audioSource.PlayOneShot(AudioManager.Instance.WinningSound);
                levelCompletePanel.SetActive(true);
                StarHandler.Instance.StarAcheived();
            }

            else
            {
                openedChest.SetActive(false);
                closedChest.SetActive(true);
                warningMsg.SetActive(true);
                isOpened = false;
                audioSource.PlayOneShot(AudioManager.Instance.chestLockSound);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        warningMsg.SetActive(false);
    }

}
