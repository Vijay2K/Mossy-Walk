using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTextInSec : MonoBehaviour
{
    [SerializeField] private float destroyInSeconds = 1f;

    private void Start() {
        Destroy(gameObject, destroyInSeconds);
    }
}
