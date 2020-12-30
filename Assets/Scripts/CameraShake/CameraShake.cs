using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance;
    private CinemachineImpulseSource source;

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

    private void Start()
    {
        source = GetComponent<CinemachineImpulseSource>();
    }

    public void Shake()
    {
        source.GenerateImpulse();
    }

}
