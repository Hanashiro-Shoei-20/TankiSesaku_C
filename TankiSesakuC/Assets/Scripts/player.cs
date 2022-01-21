using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Sprite okiteru, neteru;
    public SpriteRenderer spriteRenderer;
    public bool Sleepflg = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
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
