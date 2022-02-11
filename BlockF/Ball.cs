using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    Rigidbody ballRd;   //rigidbody ������Ʈ�� ����
    float ballSpeed = 600.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        startPos = new Vector3(0, 0, 0);    //������ ��ġ
        ballRd.AddForce(ballSpeed*0.1f, 0, -ballSpeed);  //�����̴� ����� �ӵ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 endPos = collision.transform.position;  //�浹�� ����� ������ġ����
            Vector3 incomVec = endPos - startPos;   //������ġ ���Ϳ��� �����ġ ���͸� ���� �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal;   //��������
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; //�ݻ簢 ����ȭ
            ballRd.AddForce(reflectVec * ballSpeed);    //ball�� �ݻ�� ���͹������� ���� ������ ���� �̵�

        }
        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 endPos = collision.transform.position;  //�浹�� ����� ������ġ����
            Vector3 incomVec = endPos - startPos;   //������ġ ���Ϳ��� �����ġ ���͸� ���� �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal;   //��������
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; //�ݻ簢 ����ȭ
            ballRd.AddForce(reflectVec * ballSpeed);    //ball�� �ݻ�� ���͹������� ���� ������ ���� �̵�
            GetComponent<AudioSource>().Play();

        }
        startPos = transform.position;  //���� ��ġ���� �ٽ�����
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
