using UnityEngine;
using System;

public class TrafficLightsController : MonoBehaviour
{
    [SerializeField] GameObject redLight;
    [SerializeField] GameObject yellowLight;
    [SerializeField] GameObject greenLight;
    [SerializeField][Range(0, 15)] float someNumber;

    // Start is called before the first frame update
    void Start()
    {
    }

    void SetColor(GameObject target, Color color) => target.GetComponent<MeshRenderer>().material.color = color;
    Color GetColor(GameObject target) => target.GetComponent<MeshRenderer>().material.color;

    void SetLights(bool a, bool b, bool c)
    {
        if (a) SetColor(redLight,    Color.red);    else SetColor(redLight,    Color.grey);
        if (b) SetColor(yellowLight, Color.yellow); else SetColor(yellowLight, Color.grey);
        if (c) SetColor(greenLight,  Color.green);  else SetColor(greenLight,  Color.grey);

        Debug.Log($"[{a}, {b}, {c}]");
    }

    void StartTimer(float endTime)
    {
        switch (Time.time % endTime)
        {
            case 0: SetLights(true, false, false); break;
            case 4: SetLights(true, true, false); break;
            case 6: SetLights(false, false, true); break;
            case 10: SetLights(false, true, false); break;
            default: break;
        }
    }
    void FixedUpdate()
    {
        StartTimer(someNumber);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
