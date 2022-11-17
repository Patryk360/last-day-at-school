using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float speedCube = 0.01f;
    float rotion = 0.5f;
    void Update()
    {
        transform.position +=  Vector3.back * speedCube;
        transform.Rotate(0, rotion, 0);
    }
}