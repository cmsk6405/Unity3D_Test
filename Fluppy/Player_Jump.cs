using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Jump : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpPower = 0;

    void Start()    // 한번만 실행 됨
    {
        
    }

    // Update is called once per frame
    void Update()   // 매 프레임마다 실행 됨 , FixedUpdate 고정된 값으로 업데이트
    {
     
        if (Input.GetButtonDown("Jump")) //Input
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);

            GetComponent<AudioSource>().Play();
        }

       
    }

    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("GameScene3");
    }
}
