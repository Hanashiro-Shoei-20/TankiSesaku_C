using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    private GameObject rpanel;
    private GameObject wpanel;
    private GameObject lpanel;

    public int flag = 0;
    int rlife = Mgr.GetLife();
    float rgauge = Mgr.GetGauge();

    void Start()
    {
        rpanel = GameObject.Find("Retry");
        rpanel.gameObject.SetActive(false);
        wpanel = GameObject.Find("Win");
        wpanel.gameObject.SetActive(false);
        lpanel = GameObject.Find("Lose");
        lpanel.gameObject.SetActive(false);
        rlife = 0;
        rgauge = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (rlife >= 1)
        {
            if (Input.GetButtonDown("Retry") && flag == 0)
            {
                if (rgauge >= 200)
                {
                    wpanel.gameObject.SetActive(true);
                }
                else if (rgauge <= 200)
                {
                    lpanel.gameObject.SetActive(true);
                }
                flag = 1;
            }
            else if (Input.GetButtonDown("Retry") && flag == 1)
            {
                wpanel.gameObject.SetActive(false);
                lpanel.gameObject.SetActive(false);
                rpanel.gameObject.SetActive(true);
                flag = 2;
            }
        }
        if (rlife == 0)
        {
            if (Input.GetButtonDown("Retry") && flag == 0)
            {
                lpanel.gameObject.SetActive(true);
                flag = 1;
            }
            else if (Input.GetButtonDown("Retry") && flag == 1)
            {
                lpanel.gameObject.SetActive(false);
                rpanel.gameObject.SetActive(true);
                flag = 2;
            }
        }
    }
}
