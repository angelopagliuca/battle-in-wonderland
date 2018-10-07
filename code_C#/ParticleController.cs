using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

	public Sprite Frame1;
	public Sprite Frame2;
	public Sprite Frame3;
	public Sprite Frame4;
	public float timer;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		sr = GetComponent<SpriteRenderer>();
		sr.sprite = Frame1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0.0f) {
			Destroy(gameObject);
		} else if (timer <= 0.1f) {
			sr.sprite = Frame4;
		} else if (timer <= 0.2f) {
			sr.sprite = Frame3;
		} else if (timer <= 0.3f) {
			sr.sprite = Frame2;
		} else if (timer <= 0.4f) {
			sr.sprite = Frame1;
		}
	}
}
