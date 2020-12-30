using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUmpPlant : MonoBehaviour
{
    [SerializeField] float jumpForce = 5f;

    private void OnCollisionEnter2D(Collision2D collision) 
    {      

        if(collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if(rb != null) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                
            }

            gameObject.GetComponent<AudioSource>().PlayOneShot(AudioManager.Instance.jumpPlantSound);
        }
    }
}
