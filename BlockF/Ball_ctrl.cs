using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_ctrl : MonoBehaviour
{
    float speed = 10.0f;
    Rigidbody ballRd;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            ballRd.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ballRd.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            ballRd.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ballRd.AddForce(speed, 0, 0);
        }
    }
}
