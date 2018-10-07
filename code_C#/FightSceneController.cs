using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FightSceneController : MonoBehaviour {

	public void Rematch() {
		SceneManager.LoadScene(1);
		GameManager.GM.playe1wins = 0;
		GameManager.GM.playe2wins = 0;
		GameManager.GM.round = 1;
		SoundManager.S.StopBackgroundMusic ();
		SoundManager.S.PlayTitleMusic ();
	}

	public void Menu() {
		SceneManager.LoadScene(0);
		GameManager.GM.playe1wins = 0;
		GameManager.GM.playe2wins = 0;
		GameManager.GM.round = 1;
		SoundManager.S.StopBackgroundMusic ();
		SoundManager.S.PlayTitleMusic ();
	}
}
