using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitingRocks : MonoBehaviour
{
    [SerializeField] GameObject particleBust;
    const int damage = 1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            GameObject particle = Instantiate(particleBust, transform.position, Quaternion.identity);
            Destroy(particle, 1.5f);
        }

        if(col.gameObject.tag == "Player")
        {
            CameraShake.Instance.Shake();
            col.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            Destroy(gameObject);
            GameObject particle = Instantiate(particleBust, transform.position, Quaternion.identity);
            Destroy(particle, 1.5f);

        }
    }
}
