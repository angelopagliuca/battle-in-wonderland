using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundIconController : MonoBehaviour {

	public int iconNumber;
	public Text round_num_txt;

	// Use this for initialization
	void Start () {

		round_num_txt.text = GameManager.GM.round.ToString();

		if (GameManager.GM.playe1wins == 1) {
			if (iconNumber == 1 && GameManager.GM.character1 == "Alice") {
				GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
			} else if (iconNumber == 1 && GameManager.GM.character1 == "TheBeast") {
				GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
			} else if (iconNumber == 1 && GameManager.GM.character1 == "QueenOfHearts") {
				GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
			}
		}
		if (GameManager.GM.playe2wins == 1) {
			if (iconNumber == 2 && GameManager.GM.character2 == "Alice") {
				GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
			} else if (iconNumber == 2 && GameManager.GM.character2 == "TheBeast") {
				GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
			} else if (iconNumber == 2 && GameManager.GM.character2 == "QueenOfHearts") {
				GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
			}
		}
	}
}
