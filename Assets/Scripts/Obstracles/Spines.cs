using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spines : MonoBehaviour
{
    [SerializeField] int damage = 3;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            CameraShake.Instance.Shake();
            col.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
