using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    private float destroyTime = 1f;     
    public Vector3 offset = new Vector3(0, 5, 0);

    private void Start()
    {
        Destroy(gameObject, destroyTime);
        transform.localPosition += offset;
    }
}
