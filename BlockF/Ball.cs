using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    Rigidbody ballRd;   //rigidbody 컴포넌트를 대입
    float ballSpeed = 600.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        startPos = new Vector3(0, 0, 0);    //공시작 위치
        ballRd.AddForce(ballSpeed*0.1f, 0, -ballSpeed);  //움직이는 방향과 속도
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 endPos = collision.transform.position;  //충돌한 대상위 현재위치정보
            Vector3 incomVec = endPos - startPos;   //현재위치 벡터에서 출발위치 벡터를 뺴서 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal;   //법선벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; //반사각 정규화
            ballRd.AddForce(reflectVec * ballSpeed);    //ball에 반사걱 벡터방향으로 힘이 가해져 볼이 이동

        }
        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 endPos = collision.transform.position;  //충돌한 대상위 현재위치정보
            Vector3 incomVec = endPos - startPos;   //현재위치 벡터에서 출발위치 벡터를 뺴서 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal;   //법선벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; //반사각 정규화
            ballRd.AddForce(reflectVec * ballSpeed);    //ball에 반사걱 벡터방향으로 힘이 가해져 볼이 이동
            GetComponent<AudioSource>().Play();

        }
        startPos = transform.position;  //현재 위치벡터 다시저장
        /*
        if (collision.gameObject.CompareTag("BLOCK"))
        {

            GetComponent<AudioSource>().Play();
        }
        */

        if (collision.gameObject.CompareTag("END"))
        {
            
            SceneManager.LoadScene("EndScene");
            
        }

    }

}
