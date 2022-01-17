using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//5秒ごとに振り向く　振り向き継続は1秒　振り向き継続が終了したらまた5秒計測する
public class enemy : MonoBehaviour
{
    public Material brown, red;
    float turnTime = 0;
    float spanTime = 0;
    int time = 1, flame = 0;
    public bool Turnflg = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Turn");
    }

    // Update is called once per frame
    void Update()
    {

        Turn();



        //時間計測
        flame++;
        if (flame % 120 == 0)
        {
            time++;
        }
        //

    }

    IEnumerator Turn()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Turnflg = true;
            GetComponent<Renderer>().material.color = red.color;
            yield return new WaitForSeconds(1);
            Turnflg = false;
            GetComponent<Renderer>().material.color = brown.color;
        }
    }
}
