//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;


//public class Title : MonoBehaviour
//{
//    // Start is called before the first frame update
//    private bool firstPush = false;

//    public void PressStart()
//    {
//        Debug.Log("Press Start!");
//        if (!firstPush)
//        {
//            Debug.Log("Go Next Scene!");

//            SceneManager.LoadScene("tomori");
//            //

//            //
//            firstPush = true;
//        }
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class Title : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetKey("joystick button 0")) //マウス左クリック、スペースキー、Aボタンを押した場合
		{
			SceneManager.LoadScene("Game");//Gameシーンをロードする
		}

	}
}