using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mgr : MonoBehaviour
{
    public GameObject Player, Enemy, Pnel;
    public GameObject[] lifeIcon = new GameObject[3];
    public Text TimeText;

    public static int life;

    public static float CountDown;

    bool Deflg = false;
    player Ply;
    enemy Enem;
    bool pf, ef;

    public static float SleepGauge;

    float MaxGauge = 200.0f;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        SleepGauge = 0;
        CountDown = 40.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Ply = Player.GetComponent<player>();
        pf = Ply.Sleepflg;

        Enem = Enemy.GetComponent<enemy>();
        ef = Enem.Turnflg;

        //Debug.Log(life);

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
            SleepGauge += 0.03f;
        }

        slider.value = SleepGauge / MaxGauge;

        if (SleepGauge >= MaxGauge)
        {
            slider.value = 1;

            SleepGauge = MaxGauge;

            SceneManager.LoadScene("nakama2");
        }

        if (life <= 0)
        {
            SceneManager.LoadScene("nakama2");
        }

        CountDown -= Time.deltaTime;

        TimeText.text = "TIME : " + CountDown.ToString("f1");

        if(CountDown <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    public static int GetLife()
    {
        return life;
    }

    public static float GetGauge()
    {
        return SleepGauge;
    }
}
