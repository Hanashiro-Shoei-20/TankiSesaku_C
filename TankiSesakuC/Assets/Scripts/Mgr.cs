using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mgr : MonoBehaviour
{
    public GameObject Player, Enemy, Pnel;
    public GameObject[] lifeIcon = new GameObject[3];
    int life = 3;
    bool Deflg = false;
    player Ply;
    enemy Enem;
    bool pf, ef;
    float SleepGauge = 0;
    float MaxGauge = 200.0f;
    public Slider slider;
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

        Debug.Log(life);

        if (pf == true && ef == true)
        {
            Pnel.SetActive(true);
            if (Deflg == false)
            {
                life--;
                Deflg = true;
                lifeIcon[life].SetActive(false);
            }
        }
        else
        {
            Pnel.SetActive(false);
            Deflg = false;
        }

        if (pf == true && ef == false)
        {
            SleepGauge += 0.2f;
        }

        slider.value = SleepGauge / MaxGauge;

        if (SleepGauge >= MaxGauge)
        {
            slider.value = 1;

            SleepGauge = MaxGauge;

            SceneManager.LoadScene("Clear");
        }

        if (life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
