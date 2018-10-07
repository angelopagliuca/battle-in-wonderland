using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnimator : MonoBehaviour {

	public int player;

	public Sprite AliceIdle1;
	public Sprite AliceIdle2;
	public Sprite AliceIdle3;
	public Sprite AliceIdle4;
	public Sprite AliceIdle5;
	public Sprite AliceIdle6;
	public Sprite AliceIdle7;

	public Sprite BeastIdle1;
	public Sprite BeastIdle2;
	public Sprite BeastIdle3;
	public Sprite BeastIdle4;
	public Sprite BeastIdle5;
	public Sprite BeastIdle6;
	public Sprite BeastIdle7;

	public Sprite QueenIdle1;
	public Sprite QueenIdle2;
	public Sprite QueenIdle3;
	public Sprite QueenIdle4;
	public Sprite QueenIdle5;
	public Sprite QueenIdle6;
	public Sprite QueenIdle7;

	private Sprite Idle1;
	private Sprite Idle2;
	private Sprite Idle3;
	private Sprite Idle4;
	private Sprite Idle5;
	private Sprite Idle6;
	private Sprite Idle7;

	private float timer;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		timer = 0.7f;
		sr = GetComponent<SpriteRenderer>();
		if (player == 1) {
			if (GameManager.GM.character1 == "Alice") {
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
			} else if (GameManager.GM.character1 == "TheBeast") {
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			} else if (GameManager.GM.character1 == "QueenOfHearts") {
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			}
		} else if (player == 2) {
			if (GameManager.GM.character1 == GameManager.GM.character2) {
				if (GameManager.GM.character2 == "Alice") {
					sr.color = new Color(218.0f/255.0f, 181.0f/255.0f, 115.0f/255.0f, 255.0f/255.0f);
				} else if (GameManager.GM.character2 == "TheBeast") {
					sr.color = new Color(178.0f/255.0f, 172.0f/255.0f, 225.0f/255.0f, 255.0f/255.0f);
				} else if (GameManager.GM.character2 == "QueenOfHearts") {
					sr.color = new Color(249.0f/255.0f, 218.0f/255.0f, 178.0f/255.0f, 255.0f/255.0f);
				}
			} else {
				sr.color = Color.white;
			}
			if (GameManager.GM.character2 == "Alice") {
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
			} else if (GameManager.GM.character2 == "TheBeast") {
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			} else if (GameManager.GM.character2 == "QueenOfHearts") {
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (player == 1) {
			if (GameManager.GM.character1 == "Alice") {
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
			} else if (GameManager.GM.character1 == "TheBeast") {
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			} else if (GameManager.GM.character1 == "QueenOfHearts") {
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			}
		} else if (player == 2) {
			if (GameManager.GM.character1 == GameManager.GM.character2) {
				if (GameManager.GM.character2 == "Alice") {
					sr.color = new Color(218.0f/255.0f, 181.0f/255.0f, 115.0f/255.0f, 255.0f/255.0f);
				} else if (GameManager.GM.character2 == "TheBeast") {
					sr.color = new Color(178.0f/255.0f, 172.0f/255.0f, 225.0f/255.0f, 255.0f/255.0f);
				} else if (GameManager.GM.character2 == "QueenOfHearts") {
					sr.color = new Color(249.0f/255.0f, 218.0f/255.0f, 178.0f/255.0f, 255.0f/255.0f);
				}
			} else {
				sr.color = Color.white;
			}
			if (GameManager.GM.character2 == "Alice") {
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
			} else if (GameManager.GM.character2 == "TheBeast") {
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;
				sr.flipX = true;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			} else if (GameManager.GM.character2 == "QueenOfHearts") {
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;
				sr.flipX = false;
				transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
			}
		}

		timer -= Time.deltaTime;
		if (timer <= 0.0f) {
			timer = 0.7f;
			sr.sprite = Idle7;
		} else if (timer <= 0.1f) {
			sr.sprite = Idle6;
		} else if (timer <= 0.2f) {
			sr.sprite = Idle5;
		} else if (timer <= 0.3f) {
			sr.sprite = Idle4;
		} else if (timer <= 0.4f) {
			sr.sprite = Idle3;
		} else if (timer <= 0.5f) {
			sr.sprite = Idle2;
		} else if (timer <= 0.6f) {
			sr.sprite = Idle1;
		}

	}
}
