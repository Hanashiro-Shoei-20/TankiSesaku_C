using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Retry1 : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    int startflag = 0;
    //public bool Opeflg;

    //public Button FirstSelectButton;
    Button Restart1;
    Button Title1;
    Button Exit1;

    void Awake()
    {
        Restart1 = GameObject.Find("/Menu/Retry/Exit").GetComponent<Button>();
        Title1 = GameObject.Find("/Menu/Retry/Title").GetComponent<Button>();
        Exit1 = GameObject.Find("/Menu/Retry/Restart").GetComponent<Button>();

        //Opeflg = true;
    }

    void Update()
    {
<<<<<<< HEAD
        bool start = ;

=======
        bool start = true/*Input.GetButtonDown("Pause")*/;
>>>>>>> a833072793ca07a5b667b54893b6ae580a51cef6

        if (start == true && startflag == 0)
        {

            Time.timeScale = 0f;//時間停止
            //Opeflg = false;
            Restart1.Select();
            startflag = 1;
        }

        //else if (start == true && startflag == 1)
        //{
        //    Time.timeScale = 1f;//戻る
        //    Opeflg = true;
        //    startflag = 0;
        //}
    }
}