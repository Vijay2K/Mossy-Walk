using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{
    [SerializeField] private GameObject charcterShownPanel = null;

    private void Start() {
        charcterShownPanel.SetActive(false);
    }

    public void DisplayPanel() {
        charcterShownPanel.SetActive(true);
    }

    public void ClosePanel() {
        charcterShownPanel.SetActive(false);
    }
}
