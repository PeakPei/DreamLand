﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	//退出游戏
	public void ExitGame()
	{
		Application.Quit();
	}

	//加载下一个场景
	public void LoadNextScene(String nextSceneName)
	{
		SceneManager.LoadScene(nextSceneName);
	}
}
