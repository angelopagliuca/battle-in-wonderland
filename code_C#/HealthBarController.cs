using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

	public GameObject character;
	private PlayerController pc;
	private RectTransform rt;
	private float originalWidth;

	// Use this for initialization
	void Start () {
		pc = character.GetComponent<PlayerController>();
		rt = gameObject.GetComponent<RectTransform>();
		originalWidth = rt.sizeDelta.x;
		if (pc.player == 1 && GameManager.GM.character1 == "Alice") {
			GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 1 && GameManager.GM.character1 == "TheBeast") {
			GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 1 && GameManager.GM.character1 == "QueenOfHearts") {
			GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "Alice") {
			GetComponent<Image>().color = new Color(89.0f/255.0f, 179.0f/255.0f, 236.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "TheBeast") {
			GetComponent<Image>().color = new Color(237.0f/255.0f, 136.0f/255.0f, 37.0f/255.0f, 255.0f/255.0f);
		} else if (pc.player == 2 && GameManager.GM.character2 == "QueenOfHearts") {
			GetComponent<Image>().color = new Color(185.0f/255.0f, 14.0f/255.0f, 11.0f/255.0f, 255.0f/255.0f);
		}
	}

	// Update is called once per frame
	void Update () {
		if (pc != null) 
			rt.sizeDelta = new Vector2((pc.health / 100.0f) * originalWidth, rt.sizeDelta.y);
	}
}
