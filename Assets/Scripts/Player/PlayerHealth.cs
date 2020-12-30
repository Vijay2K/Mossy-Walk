using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    [SerializeField] private GameObject floatingTextPrefab = null;
    [SerializeField] int maxHealth;
    public int currentHealth;
    [SerializeField] Image[] hearts;
    [SerializeField] GameObject particles;     
    AudioSource audioSource;
    
    public bool isDead;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
        audioSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        if (isDead)
        { 
           
            Debug.Log("The player is dead");
            Destroy(gameObject);            
            GameObject playerBust = Instantiate(particles, transform.position, quaternion.identity);
            Destroy(playerBust, 1.5f);           
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        } 
      
    } 
   
    public void TakeDamage(int damage)
    {
        if(currentHealth >= 0)
        {
            Instantiate(floatingTextPrefab, transform.position, quaternion.identity);
            currentHealth -= damage;
            if(currentHealth <= 0)
            {
                isDead = true;                
            }            
            audioSource.PlayOneShot(AudioManager.Instance.damageSound);
            
        }        
    } 

   

   
   
}
