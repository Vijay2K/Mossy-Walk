using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] characters = null;
    private int selectedCharacters = 0;

    public void NextCharacter() {
        characters[selectedCharacters].SetActive(false);
        selectedCharacters = (selectedCharacters + 1) % characters.Length;
        characters[selectedCharacters].SetActive(true);
    }

    public void PreviousCharacter() {
        characters[selectedCharacters].SetActive(false);
        selectedCharacters--;
        if(selectedCharacters < 0) {
            selectedCharacters += characters.Length;
        }

        characters[selectedCharacters].SetActive(true);
    }
}
