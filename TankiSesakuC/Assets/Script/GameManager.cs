﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    public void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Title()
    {
        //SceneManager.LoadScene("TitleScene");
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }
}