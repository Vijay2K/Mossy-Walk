using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimes : MonoBehaviour
{
    [SerializeField] int damage = 1;    
    [SerializeField] GameObject particleEffects;
   

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {           
            GameObject particles = Instantiate(particleEffects, col.transform.position, Quaternion.identity);
            col.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

            Destroy(particles, 1f);
        }
    }
}
