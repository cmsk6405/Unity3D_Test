using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    Rigidbody blockRd;
    

    // Start is called before the first frame update
    void Start()
    {
        blockRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BALL"))
        {

           
            Destroy(gameObject);
        }
    }
}           