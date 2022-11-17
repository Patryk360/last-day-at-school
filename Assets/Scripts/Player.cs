using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speedPlayer = 0.5f;
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position +=  Vector3.forward * speedPlayer;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position +=  Vector3.back * speedPlayer;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position +=  Vector3.left * speedPlayer;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position +=  Vector3.right * speedPlayer;
        }

        transform.Rotate(moveY, moveX, 0);
    }
}