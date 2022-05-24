using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CMControl : MonoBehaviour
{
    private static CMControl instance = null;
    private CinemachineVirtualCamera vcam;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {

    }

}
