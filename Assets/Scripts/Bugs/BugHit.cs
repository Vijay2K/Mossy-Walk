using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugHit : MonoBehaviour
{
    const int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CameraShake.Instance.Shake();
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
