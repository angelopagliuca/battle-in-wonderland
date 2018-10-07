using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconController : MonoBehaviour {

	public Sprite Alice;
	public Sprite Beast;
	public Sprite Queen;
	public int player;
	private Image sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<Image>();
		if (player == 1) {
			if (GameManager.GM.character1 == "Alice") {
				sr.sprite = Alice;
			} else if (GameManager.GM.character1 == "TheBeast") {
				sr.sprite = Beast;
			} else if (GameManager.GM.character1 == "QueenOfHearts") {
				sr.sprite = Queen;
			}
		} else if (player == 2) {
			if (GameManager.GM.character2 == "Alice") {
				sr.sprite = Alice;
			} else if (GameManager.GM.character2 == "TheBeast") {
				sr.sprite = Beast;
			} else if (GameManager.GM.character2 == "QueenOfHearts") {
				sr.sprite = Queen;
			}
		}
	}
}
