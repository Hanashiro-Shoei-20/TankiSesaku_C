using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//5秒ごとに振り向く　振り向き継続は1秒　振り向き継続が終了したらまた5秒計測する
public class enemy : MonoBehaviour
{
    public Sprite bansyo, furimuki, tirami;
    public SpriteRenderer spriteRenderer;
    float turnTime = 0;
    float spanTime = 0;
    int time = 1, flame = 0, Feint = 0;
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

        Debug.Log(Feint);

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
            yield return new WaitForSeconds(Random.Range(1,8));
            spriteRenderer.sprite = tirami;
            Feint = Random.Range(1, 10);

            if(Feint != 1)
            {
                yield return new WaitForSeconds(0.28f);
                spriteRenderer.sprite = furimuki;
                Turnflg = true;
            }           

            yield return new WaitForSeconds(1);
            Turnflg = false;
            spriteRenderer.sprite = bansyo;
        }
    }
}
