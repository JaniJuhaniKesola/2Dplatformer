using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private int _i;

    void Start()
    {
        Debug.Log("Hello World!");
    }

    void Update()
    {
        if (_i <= 1000) {
            Debug.Log("Frame: " + _i);
            _i++;
        }
    }
}
