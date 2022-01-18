using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject Player, Enemy, Pnel;
    player Ply;
    enemy Enem;
    bool pf, ef;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ply = Player.GetComponent<player>();
        pf = Ply.Sleepflg;

        Enem = Enemy.GetComponent<enemy>();
        ef = Enem.Turnflg;

        if (pf == true && ef == true)
        {
            Pnel.SetActive(true);
        }
        else
        {
            Pnel.SetActive(false);
        }
    }
}
