using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    string test1 = "Terve";
    string test2 = "Hello";

    public GameObject Arm, Parent;

    public Material[] Color;

    public enum color 
    {
        black = 0, grey = 3, white = 6, 
        blue = 1, green = 2, yellow = 7, 
        orange = 4, red = 5, darkgreen = 8, 
        darkred = 9, darkyellow = 10 
    }

    float temp1 = 10f;
    float temp2 = 50f;
    float temp3 = 30f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(test1 == test2);
        
    }

    // Update is called once per frame
    void Update()
    {

        Parent.GetComponent<MeshRenderer>().material = temp1 > temp2 % 180 ? Color[(int)color.red] : Color[(int)color.yellow];

        temp1 += 0.01f;

        Arm.transform.localRotation = Quaternion.Euler(0, 90-temp1, 0);

        if (test1 != test2) return;
        else Debug.Log("juu");

    }
}
