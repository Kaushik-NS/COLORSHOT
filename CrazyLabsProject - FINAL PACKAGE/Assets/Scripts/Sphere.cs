using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject Cube;
    public int speed;
    private Vector3 axis = Vector3.up;
    void Update()
    {
        this.transform.RotateAround(Vector3.zero, Vector3.up, 1.0f);
        transform.RotateAround(Cube.transform.position, axis, speed * Time.deltaTime);
    }
}
