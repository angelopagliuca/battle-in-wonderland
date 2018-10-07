using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResidueHealthBarController : MonoBehaviour {

	public GameObject character;
	private PlayerController pc;
	private RectTransform rt;
	private float originalWidth;

	// Use this for initialization
	void Start () {
		pc = character.GetComponent<PlayerController>();
		rt = gameObject.GetComponent<RectTransform>();
		originalWidth = rt.sizeDelta.x;
	}

	// Update is called once per frame
	void Update () {
		if (pc != null) 
			rt.sizeDelta = new Vector2((pc.residue_health / 100.0f) * originalWidth, rt.sizeDelta.y);
	}
}
