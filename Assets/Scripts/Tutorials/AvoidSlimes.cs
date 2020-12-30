using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidSlimes : MonoBehaviour
{
    [SerializeField] GameObject warnSlime;
    bool isEnter;

    private void Start()
    {
        isEnter = true;
        warnSlime.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (isEnter == true)
            {
                warnSlime.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEnter = false;
        warnSlime.SetActive(false);
    }
}
