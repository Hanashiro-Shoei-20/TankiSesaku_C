using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Material green, blue;
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
            GetComponent<Renderer>().material.color = blue.color;
            Sleepflg = true;
        }
        else
        {
            GetComponent<Renderer>().material.color = green.color;
            Sleepflg = false;
        }
    }
}
