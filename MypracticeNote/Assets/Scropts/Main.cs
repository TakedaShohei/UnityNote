﻿using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F");
        }
    }
}
