using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ctrl : MonoBehaviour
{

    public float dropSpeed = -0.01f;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);
        if(transform.position.y<-0.5)
        {
            Destroy(gameObject);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            AudioSource.PlayClipAtPoint(clip, new Vector3(x, 0, z));
            //(clip,gameObject.transform.position)
        }
    }
}
