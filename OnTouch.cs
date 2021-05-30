using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTouch : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void onClickToGame()
	{
		SceneManager.LoadScene("main");
	}

	public void onClickToEnd()
    {
		Application.Quit();
    }
}