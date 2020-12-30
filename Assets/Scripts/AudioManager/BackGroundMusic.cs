﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public static BackGroundMusic Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
