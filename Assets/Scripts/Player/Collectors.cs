using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;

public class Collectors : MonoBehaviour
{
   
    [SerializeField] TextMeshProUGUI coins;
    [SerializeField] TextMeshProUGUI gems;
    [SerializeField] TextMeshProUGUI key;
    [SerializeField] GameObject coinEffect;
    [SerializeField] GameObject gemEffect;
    [SerializeField] GameObject keyEffect;
    AudioSource audioSource;

    public int coinCount;
    public int gemCount;
    public int keyCount;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "coins")
        {
            coinCount++;
            coins.text = coinCount.ToString();
            Destroy(col.gameObject);
            GameObject particle = Instantiate(coinEffect, col.transform.position, quaternion.identity);
            Destroy(particle, 1.5f);
            audioSource.PlayOneShot(AudioManager.Instance.coinPickSound);
        }

        if(col.gameObject.tag == "gems")
        {
            gemCount++;
            gems.text = gemCount.ToString();
            Destroy(col.gameObject);
            GameObject particle = Instantiate(gemEffect, col.transform.position, quaternion.identity);
            Destroy(particle, 1.5f);
            audioSource.PlayOneShot(AudioManager.Instance.gemPickSound);
        }

        if(col.gameObject.tag == "keys")
        {
            keyCount++;
            key.text = keyCount.ToString();
            Destroy(col.gameObject);
            audioSource.PlayOneShot(AudioManager.Instance.keyPicksound);
        }
    }

}
