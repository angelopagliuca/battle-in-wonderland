using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelecter : MonoBehaviour {

	public int player;
	private KeyCode JoyConKey_A;
	private KeyCode JoyConKey_X;
	private string JoyConVertical;
	private float switchTimer;

	public GameObject other;
	public GameObject Alice;
	public GameObject QueenOfHearts;
	public GameObject TheBeast;

	// 0 - Alice
	// 1 - Queen of Hearts
	// 2 - The Beast
	private int currentSelection;
	public bool lockedDown;

	private Color unselectedColor;
	private Color selectedColor;
	private Color lockedColor;

	// Use this for initialization
	void Start () {
		lockedColor = new Color(234.0f/256.0f, 53.0f/256.0f, 53.0f/256.0f, 154.0f/256.0f);
		selectedColor = new Color(240.0f/256.0f, 242.0f/256.0f, 110.0f/256.0f, 154.0f/256.0f);
		unselectedColor = new Color(0.0f, 0.0f, 0.0f, 0.0f);
		if (player == 1) {
			JoyConKey_A = KeyCode.Joystick1Button0;
			JoyConKey_X = KeyCode.Joystick1Button1;
			JoyConVertical = "JoyConVertical_1";
			currentSelection = 0;
			switchTimer = 0.0f;
			lockedDown = false;
		} else if (player == 2) {
			JoyConKey_A = KeyCode.Joystick2Button0;
			JoyConKey_X = KeyCode.Joystick2Button1;
			JoyConVertical = "JoyConVertical_2";
			currentSelection = 1;
			switchTimer = 0.0f;
			lockedDown = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (lockedDown && other.GetComponent<CharacterSelecter>().lockedDown && player == 1) {
			SceneManager.LoadScene(3);
			SoundManager.S.StopTitleMusic ();
			SoundManager.S.PlayBackgroundMusic ();
		}

		if (!lockedDown) {
			if (switchTimer == 0.0f) {
				float vert = Input.GetAxis(JoyConVertical);
				if (vert > 0.5f) {
					switchTimer = 0.2f;
					if (currentSelection == 0) {
						currentSelection = 2;
					} else {
						currentSelection--;
					}
					SoundManager.S.PlayClickSound();
				} else if (vert < -0.5f) {
						switchTimer = 0.2f;
						if (currentSelection == 2) {
							currentSelection = 0;
						} else {
							currentSelection++;
						}
						SoundManager.S.PlayClickSound();
				}
			} else {
				switchTimer -= Time.deltaTime;
				if (switchTimer <= 0.0f) {
					switchTimer = 0.0f;
				}
			}

			if (Input.GetKeyDown(JoyConKey_A)) {
				lockedDown = true;
				SoundManager.S.PlayLockSound();
		 	} else if (Input.GetKeyDown(JoyConKey_X)) {
				SceneManager.LoadScene(0);
			}

			if (currentSelection == 0) {
				if (player == 1) {
					GameManager.GM.character1 = "Alice";
				} else if (player == 2) {
					GameManager.GM.character2 = "Alice";
				}
			} else if (currentSelection == 1) {
				if (player == 1) {
					GameManager.GM.character1 = "QueenOfHearts";
				} else if (player == 2) {
					GameManager.GM.character2 = "QueenOfHearts";
				}
			} else if (currentSelection == 2) {
				if (player == 1) {
					GameManager.GM.character1 = "TheBeast";
				} else if (player == 2) {
					GameManager.GM.character2 = "TheBeast";
				}
			}

		} else {
			if (Input.GetKeyDown(JoyConKey_X)) {
				lockedDown = false;
			}
		}

		if (currentSelection == 0) {
			if (lockedDown) {
				Alice.GetComponent<Image> ().color = lockedColor;
			} else {
				Alice.GetComponent<Image> ().color = selectedColor;
			}
			QueenOfHearts.GetComponent<Image>().color = unselectedColor;
			TheBeast.GetComponent<Image> ().color = unselectedColor;
		} else if (currentSelection == 1) {
			if (lockedDown) {
				QueenOfHearts.GetComponent<Image> ().color = lockedColor;
			} else {
				QueenOfHearts.GetComponent<Image> ().color = selectedColor;
			}
			Alice.GetComponent<Image> ().color = unselectedColor;
			TheBeast.GetComponent<Image> ().color = unselectedColor;
		} else if (currentSelection == 2) {
			if (lockedDown) {
				TheBeast.GetComponent<Image> ().color = lockedColor;
			} else {
				TheBeast.GetComponent<Image> ().color = selectedColor;
			}
			QueenOfHearts.GetComponent<Image> ().color = unselectedColor;
			Alice.GetComponent<Image> ().color = unselectedColor;
		}
	}
}
