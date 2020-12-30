using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRocks : MonoBehaviour
{
    private int damage = 1;
    [SerializeField] GameObject particleBurst;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CameraShake.Instance.Shake();
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            Destroy(gameObject);
            GameObject particles = Instantiate(particleBurst, transform.position, Quaternion.identity);
            Destroy(particles, 1.5f);
        }

        if (collision.gameObject.tag == "MovingPlatform")
        {
            Destroy(gameObject);
            GameObject particles = Instantiate(particleBurst, transform.position, Quaternion.identity);
            Destroy(particles, 1.5f);
        }
    }
}
