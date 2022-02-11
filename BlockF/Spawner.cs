using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject BlockPrefab;
    public float spawn = 1.0f;
    public float range = 0;
    float delta = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.spawn)
        {
            this.delta = 0;
            GameObject wall = Instantiate(BlockPrefab) as GameObject;
            wall.transform.position = new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));

        }
    }
}
