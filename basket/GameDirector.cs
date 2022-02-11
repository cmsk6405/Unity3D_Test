using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject timerText;
    GameObject pointText;
    public float time = 60.0f;
    public int point = 100;

    GameObject getScore;

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point -= 50;
    }


    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Timer");
        this.pointText = GameObject.Find("Point");
        this.getScore = GameObject.Find("Basket_ctrl");
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F2");
        this.pointText.GetComponent<Text>().text = this.point.ToString("D6") + "Á¡";
    }
}
