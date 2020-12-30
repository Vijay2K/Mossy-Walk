using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidSpitRocks : MonoBehaviour
{
    [SerializeField] GameObject warnBalls;
    bool isEntered;


    private void Start()
    {
        isEntered = true;
        warnBalls.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(isEntered == true)
            {
                warnBalls.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEntered = false;
        warnBalls.SetActive(false);
    }
}
