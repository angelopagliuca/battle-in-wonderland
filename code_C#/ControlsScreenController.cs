﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsScreenController : MonoBehaviour {

	public void Play() {
		SceneManager.LoadScene(1);
	}

	public void Back() {
		SceneManager.LoadScene(0);
	}

}