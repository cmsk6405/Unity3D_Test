using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Gen : MonoBehaviour
{

    public GameObject 汗力前荤苞;
    public GameObject 汗力前气藕;
    public float reSpawn = 1.0f;
    float delta = 0;
    public int ratio = 3;
    public float speed = -0.03f;

    public AudioClip clip;

    public void Setparameter(float reSpawn, float speed, int ratio)
    {
        this.reSpawn = reSpawn;
        this.speed = speed;
        this.ratio = ratio;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.delta += Time.deltaTime;
        if (this.delta > reSpawn)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 20);
            if (dice <= this.ratio)
            {
                item = Instantiate(汗力前气藕) as GameObject;
            }
            else
            {
                item = Instantiate(汗力前荤苞) as GameObject;
            }

            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 3, z);
            item.GetComponent<Item_ctrl>().dropSpeed = this.speed;
            
           
           // AudioSource.PlayClipAtPoint(clip, new Vector3(x, -1, z));
        }

    }
}
