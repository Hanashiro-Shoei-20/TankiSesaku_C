using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Menu : MonoBehaviour
{
    //[SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    int startflag = 0;

    //public Button FirstSelectButton;
    Button Restart;
    Button Title;
    Button Exit;

    void Awake()
    {
        Restart = GameObject.Find("/Menu/Button").GetComponent<Button>();
        Title = GameObject.Find("/Menu/Button1").GetComponent<Button>();
        Exit = GameObject.Find("/Menu/Button2").GetComponent<Button>();
        pausePanel.SetActive(false);

        //pauseButton.onClick.AddListener(Pause);
        //resumeButton.onClick.AddListener(Resume);

    }

    void Update()
    {
        bool start = Input.GetButtonDown("Pause");


        if (start == true && startflag == 0)
        {

            Time.timeScale = 0f;//時間停止
            pausePanel.SetActive(true);
            Restart.Select();
            startflag = 1;

            Debug.Log("START");
            Debug.Log(startflag);
        }

        else if (start == true && startflag == 1)
        {
            Time.timeScale = 1f;//戻る
            pausePanel.SetActive(false);

            EventSystem.current.SetSelectedGameObject(null);
            startflag = 0;


            Debug.Log("START");
            Debug.Log(startflag);

        }
        //Debug.Log(startflag);

    }

    //        Time.timeScale = 1;//再開
    //        pausePanel.SetActive(false);
}