using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitPlant : MonoBehaviour
{
    public static SpitPlant Instance;

    [SerializeField] GameObject spitRock;
    [SerializeField] Transform spawnPos;
    [SerializeField] float spawningTime;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        InvokeRepeating("SpitingRocks", 2f, spawningTime);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpitingRocks");
    }

    private void SpitingRocks()
    {
        Instantiate(spitRock, spawnPos.position, Quaternion.identity);
    }
}
