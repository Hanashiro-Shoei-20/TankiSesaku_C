using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    private GameObject wpanel;
    private GameObject lpanel;
    private GameObject rpanel;
    private GameObject repanel;
    public int count;
    public int flag = 0;
    void Start()
    {
        wpanel = GameObject.Find("win");
        wpanel.gameObject.SetActive(false);
        lpanel = GameObject.Find("lose");
        lpanel.gameObject.SetActive(false);
        rpanel = GameObject.Find("Result");
        rpanel.gameObject.SetActive(false);
        repanel = GameObject.Find("Retry");
        repanel.gameObject.SetActive(false);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count =+ 1;
        if(count >= 1)
        {
            if(Input.GetButtonDown("Retry") && flag == 0)
            {
                flag = 1;
                wpanel.gameObject.SetActive(true);
            }

            else if(Input.GetButtonDown("Retry") && flag == 1)
            {
                flag = 2;
                wpanel.gameObject.SetActive(false);
                rpanel.gameObject.SetActive(true);
            }

            else if(Input.GetButtonDown("Retry") && flag == 2)
            {
                flag = 3;
                rpanel.gameObject.SetActive(false);
                repanel.gameObject.SetActive(true);
            }
        }
    }
}
