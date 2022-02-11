using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Move : MonoBehaviour
{
    public float wallSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(wallSpeed*Time.deltaTime, 0, 0);
    }
}
