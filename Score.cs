
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

	public GameObject WinMenu;

	static public int score = 0;

	// Use this for initialization
	void Start()
	{
		WinMenu.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (score == 28)
		{
			Win();
			
		}

	}

	void Win()
    {
		WinMenu.SetActive(true);
		Time.timeScale = 0f;
	}

	public void GoToResult()
    {
		SceneManager.LoadScene("Result");
	}
}