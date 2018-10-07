using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager GM = null;

	public bool musicTurnOn = true;

	public string character1;
	public string character2;

	public int round = 1;
	public int playe1wins = 0;
	public int playe2wins = 0;

	void Awake() {
		if (GM == null) {
			GM = this;
			GM.character1 = "Alice";
			GM.character2 = "Alice";
		} else if (GM != this) {
			Destroy(gameObject);
		}
			
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		SoundManager.S.PlayTitleMusic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
