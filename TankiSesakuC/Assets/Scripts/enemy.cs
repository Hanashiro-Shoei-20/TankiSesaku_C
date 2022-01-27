using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//5秒ごとに振り向く　振り向き継続は1秒　振り向き継続が終了したらまた5秒計測する
public class enemy : MonoBehaviour
{
    AudioSource audioSource;
    public Sprite bansyo, furimuki, tirami;
    public SpriteRenderer spriteRenderer;
    public GameObject menu;
    float turnTime = 0;
    float spanTime = 0;
    int time = 1, flame = 0, Feint = 0;
    public bool Turnflg = false;
    Menu mem;
    bool SF = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Turn");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        mem = menu.GetComponent<Menu>();
        SF = mem.Opeflg;

        //if(SF == false)
        //{
        //    audioSource.Stop();
        //}

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
            audioSource.Stop();
            Feint = Random.Range(1, 10);

            if(Feint != 1)
            {
                yield return new WaitForSeconds(Random.Range(0.28f, 0.5f));
                spriteRenderer.sprite = furimuki;
                Turnflg = true;
            }           

            yield return new WaitForSeconds(1);
            Turnflg = false;
            spriteRenderer.sprite = bansyo;
            audioSource.Play();
        }
    }
}
