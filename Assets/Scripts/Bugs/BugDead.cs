using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDead : MonoBehaviour
{
    [SerializeField] GameObject particles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {            
            StartCoroutine(Dead());
        }
    }

    IEnumerator Dead()
    {
        gameObject.GetComponent<BugPatrolPath>().speed = 0f;

        gameObject.GetComponent<Animator>().SetBool("isDead", true);

        yield return new WaitForSeconds(0.5f);

        GameObject particleSystem = Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(particleSystem, 1f);

    }

}
