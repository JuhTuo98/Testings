using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Functions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PrintName("Matti");
        Debug.Log(GenerateBandName("Matti"));
        Debug.Log(Hypotenuse(3f, 4f));

    }

    void PrintName (string argument1) 
    {
        Debug.Log($"My name is {argument1}");
    }

    string GenerateBandName (string name) 
    {
        return $"{name} and Teppo";
    }

    string GenerateBetterBandName (string name1, string name2, string name3) 
    {
        return $"{name1}, {name2}, {name3} and Teppo";
    }

    string GenerateBetterBandName (string name1, string name2, int number) 
    {
        return $"{name1}, {name2}, {number} and Teppo";
    }

    float Hypotenuse (float a, float b) 
    {
        return Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));
    }

    public static float ShorterHypotenuse (float a, float b) => Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));


    // Update is called once per frame
    void Update()
    {
        
    }
}
