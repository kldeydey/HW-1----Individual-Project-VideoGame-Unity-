﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	
	public void buttonOneClicked()
	{
		SceneManager.LoadScene ("RollABall", LoadSceneMode.Single);
	}
	public void buttonTwoClicked()
	{
		SceneManager.LoadScene ("MyGame", LoadSceneMode.Single);
	}
	public void buttonExitClicked()
	{
		Application.Quit ();
	}
}
