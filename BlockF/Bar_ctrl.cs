using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_ctrl : MonoBehaviour
{

    float speed = 10.0f;
    Rigidbody playerRd;


    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
