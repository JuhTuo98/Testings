using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables: MonoBehaviour
{
    double a, b;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sum: " + (a + b));
        Debug.Log("Diff: " + (a - b));
        Debug.Log("Fract: " + (a / b));
        Debug.Log("Prod: " + (a * b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}