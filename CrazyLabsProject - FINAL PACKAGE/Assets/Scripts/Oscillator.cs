using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float TimeCounter = 0;
    public float speed;
    public float width;
    public float height;
    void Start()
    {
        //width = 4;
        //height = 4;
    }

    void Update()
    {
        TimeCounter += Time.deltaTime*speed;
        float x = Mathf.Cos(TimeCounter)*width;
        float y = Mathf.Sin(TimeCounter)*height;
        float z = 0;
        transform.position = new Vector3(x, y, z);
    }
}
