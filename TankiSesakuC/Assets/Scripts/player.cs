using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Sprite okiteru, neteru;
    public SpriteRenderer spriteRenderer;
    public GameObject menu;
    public bool Sleepflg = false;
    Menu men;
    bool of = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        men = menu.GetComponent<Menu>();
        of = men.Opeflg;

        if(of == true)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey("joystick button 0"))
            {
                Sleepflg = true;
                spriteRenderer.sprite = neteru;
            }
            else
            {
                Sleepflg = false;
                spriteRenderer.sprite = okiteru;
            }
        }
    }
}
