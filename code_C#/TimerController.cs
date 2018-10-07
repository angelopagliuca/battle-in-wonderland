using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

	public Transform LoadingBar;
	public GameObject player;
	public PlayerController pc;

	public float currentTime;
	public float maxTime;
	public Color background;

	void Start() {
		pc = player.GetComponent<PlayerController>();
		if (pc.player == 1 && GameManager.GM.character1 == "Alice") {
			LoadingBar.GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 1 && GameManager.GM.character1 == "TheBeast") {
			LoadingBar.GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 1 && GameManager.GM.character1 == "QueenOfHearts") {
			LoadingBar.GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "Alice") {
			LoadingBar.GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "TheBeast") {
			LoadingBar.GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "QueenOfHearts") {
			LoadingBar.GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
		}
	}

	void Update() {
		if (currentTime < maxTime) {
			currentTime += Time.deltaTime;
			if (currentTime >= maxTime) {
				currentTime = maxTime;
				pc.abilityAvailable = true;
			}
		}
		LoadingBar.GetComponent<Image>().fillAmount = currentTime / maxTime;
	}

	public void SetTimer() {
		currentTime = 0.0f;
	}
}
