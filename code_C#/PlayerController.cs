using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public int player;
	public float speed;
	public float dashSpeed;
	public float jumpSpeed;
	public float health = 100.0f;
	public float residue_health = 100.0f;
	public float previous_health = 100.0f;
	private float residue_health_timer = 0.0f;
	public float special = 0.0f;
	public GameObject otherGO;
	private SpriteRenderer sr;
	private Rigidbody2D rb;
	public GameObject basicAttackCollider;
	public GameObject ultimateGlow;
	public GameObject visualCooldownTimer;

	public GameObject rematch_button;
	public GameObject menu_button;
	public Text CharacterWin_txt;
	public Text round_txt;
	public GameObject EventSystem;

	private bool queenChangeSize;

	private bool changedSprite;

	// Alice

	public Sprite AliceNormal;
	public Sprite AliceBlock;
	public Sprite AliceCrouch;

	// Dash
	public Sprite AliceDashForward;
	public Sprite AliceDashBack;

	// Jump
	public Sprite AliceJump1;
	public Sprite AliceJump2;
	public Sprite AliceJump3;
	public Sprite AliceJump4;

	// Basic Attack
	public Sprite AlicePunch1;
	public Sprite AlicePunch2;
	public Sprite AlicePunch3;
	public Sprite AlicePunch4;

	// Idle
	public Sprite AliceIdle1;
	public Sprite AliceIdle2;
	public Sprite AliceIdle3;
	public Sprite AliceIdle4;
	public Sprite AliceIdle5;
	public Sprite AliceIdle6;
	public Sprite AliceIdle7;

	// Move
	public Sprite AliceMove1;
	public Sprite AliceMove2;
	public Sprite AliceMove3;
	public Sprite AliceMove4;
	public Sprite AliceMove5;
	public Sprite AliceMove6;
	public Sprite AliceMove7;
	public Sprite AliceMove8;

	// Flinch
	public Sprite AliceFlinch;

	// Ability 
	public Sprite AliceAbility1;
	public Sprite AliceAbility2;
	public Sprite AliceAbility3;
	public Sprite AliceAbility4;
	public Sprite AliceAbility5;
	public Sprite AliceAbility6;
	public Sprite AliceAbility7;
	public Sprite AliceAbility8;
	public Sprite AliceAbility9;
	public Sprite AliceAbility10;
	public Sprite AliceAbility11;

	// Special
	public Sprite AliceSpecial1;
	public Sprite AliceSpecial2;
	public Sprite AliceSpecial3;
	public Sprite AliceSpecial4;
	public Sprite AliceSpecial5;
	public Sprite AliceSpecial6;

	// Victory
	public Sprite AliceVictory1;
	public Sprite AliceVictory2;
	public Sprite AliceVictory3;
	public Sprite AliceVictory4;
	public Sprite AliceVictory5;
	public Sprite AliceVictory6;
	public Sprite AliceVictory7;
	public Sprite AliceVictory8;

	// Defeat
	public Sprite AliceDefeat1;
	public Sprite AliceDefeat2;
	public Sprite AliceDefeat3;
	public Sprite AliceDefeat4;
	public Sprite AliceDefeat5;
	public Sprite AliceDefeat6;
	public Sprite AliceDefeat7;
	public Sprite AliceDefeat8;
	public Sprite AliceDefeat9;

	// Particles
	public GameObject AliceBasicHitParticles;
	public GameObject AliceSpecialHitParticles;
	public GameObject AliceMissParticles;
	public GameObject AliceBlockParticles;


	// The Beast

	public Sprite BeastNormal;
	public Sprite BeastBlock;
	public Sprite BeastCrouch;

	// Dash
	public Sprite BeastDashForward;
	public Sprite BeastDashBack;

	// Jump
	public Sprite BeastJump1;
	public Sprite BeastJump2;
	public Sprite BeastJump3;
	public Sprite BeastJump4;

	// Basic Attack
	public Sprite BeastPunch1;
	public Sprite BeastPunch2;
	public Sprite BeastPunch3;
	public Sprite BeastPunch4;

	// Idle
	public Sprite BeastIdle1;
	public Sprite BeastIdle2;
	public Sprite BeastIdle3;
	public Sprite BeastIdle4;
	public Sprite BeastIdle5;
	public Sprite BeastIdle6;
	public Sprite BeastIdle7;

	// Move
	public Sprite BeastMove1;
	public Sprite BeastMove2;
	public Sprite BeastMove3;
	public Sprite BeastMove4;
	public Sprite BeastMove5;
	public Sprite BeastMove6;
	public Sprite BeastMove7;
	public Sprite BeastMove8;

	// Flinch
	public Sprite BeastFlinch;

	// Ability 
	public Sprite BeastAbility1;
	public Sprite BeastAbility2;
	public Sprite BeastAbility3;
	public Sprite BeastAbility4;
	public Sprite BeastAbility5;
	public Sprite BeastAbility6;
	public Sprite BeastAbility7;
	public Sprite BeastAbility8;
	public Sprite BeastAbility9;
	public Sprite BeastAbility10;
	public Sprite BeastAbility11;

	// Special
	public Sprite BeastSpecial1;
	public Sprite BeastSpecial2;
	public Sprite BeastSpecial3;
	public Sprite BeastSpecial4;
	public Sprite BeastSpecial5;
	public Sprite BeastSpecial6;

	// Victory
	public Sprite BeastVictory1;
	public Sprite BeastVictory2;
	public Sprite BeastVictory3;
	public Sprite BeastVictory4;
	public Sprite BeastVictory5;
	public Sprite BeastVictory6;
	public Sprite BeastVictory7;
	public Sprite BeastVictory8;

	// Defeat
	public Sprite BeastDefeat1;
	public Sprite BeastDefeat2;
	public Sprite BeastDefeat3;
	public Sprite BeastDefeat4;
	public Sprite BeastDefeat5;
	public Sprite BeastDefeat6;
	public Sprite BeastDefeat7;
	public Sprite BeastDefeat8;
	public Sprite BeastDefeat9;

	// Particles
	public GameObject BeastBasicHitParticles;
	public GameObject BeastSpecialHitParticles;
	public GameObject BeastMissParticles;
	public GameObject BeastBlockParticles;


	// Queen

	public Sprite QueenNormal;
	public Sprite QueenBlock;
	public Sprite QueenCrouch;

	// Dash
	public Sprite QueenDashForward;
	public Sprite QueenDashBack;

	// Jump
	public Sprite QueenJump1;
	public Sprite QueenJump2;
	public Sprite QueenJump3;
	public Sprite QueenJump4;

	// Basic Attack
	public Sprite QueenPunch1;
	public Sprite QueenPunch2;
	public Sprite QueenPunch3;
	public Sprite QueenPunch4;

	// Idle
	public Sprite QueenIdle1;
	public Sprite QueenIdle2;
	public Sprite QueenIdle3;
	public Sprite QueenIdle4;
	public Sprite QueenIdle5;
	public Sprite QueenIdle6;
	public Sprite QueenIdle7;

	// Move
	public Sprite QueenMove1;
	public Sprite QueenMove2;
	public Sprite QueenMove3;
	public Sprite QueenMove4;
	public Sprite QueenMove5;
	public Sprite QueenMove6;
	public Sprite QueenMove7;
	public Sprite QueenMove8;

	// Flinch
	public Sprite QueenFlinch;

	// Ability 
	public Sprite QueenAbility1;
	public Sprite QueenAbility2;
	public Sprite QueenAbility3;
	public Sprite QueenAbility4;
	public Sprite QueenAbility5;
	public Sprite QueenAbility6;
	public Sprite QueenAbility7;
	public Sprite QueenAbility8;
	public Sprite QueenAbility9;
	public Sprite QueenAbility10;
	public Sprite QueenAbility11;

	// Special
	public Sprite QueenSpecial1;
	public Sprite QueenSpecial2;
	public Sprite QueenSpecial3;
	public Sprite QueenSpecial4;
	public Sprite QueenSpecial5;
	public Sprite QueenSpecial6;

	// Victory
	public Sprite QueenVictory1;
	public Sprite QueenVictory2;
	public Sprite QueenVictory3;
	public Sprite QueenVictory4;
	public Sprite QueenVictory5;
	public Sprite QueenVictory6;
	public Sprite QueenVictory7;
	public Sprite QueenVictory8;

	// Defeat
	public Sprite QueenDefeat1;
	public Sprite QueenDefeat2;
	public Sprite QueenDefeat3;
	public Sprite QueenDefeat4;
	public Sprite QueenDefeat5;
	public Sprite QueenDefeat6;
	public Sprite QueenDefeat7;
	public Sprite QueenDefeat8;
	public Sprite QueenDefeat9;

	// Particles
	public GameObject QueenBasicHitParticles;
	public GameObject QueenSpecialHitParticles;
	public GameObject QueenMissParticles;
	public GameObject QueenBlockParticles;


	////////////////////

	// Private

	private Sprite Normal;
	private Sprite Block;
	private Sprite Crouch;

	// Dash
	public Sprite DashForward;
	public Sprite DashBack;

	// Jump
	private Sprite Jump1;
	private Sprite Jump2;
	private Sprite Jump3;
	private Sprite Jump4;

	// Basic Attack
	private Sprite Punch1;
	private Sprite Punch2;
	private Sprite Punch3;
	private Sprite Punch4;

	// Idle
	private Sprite Idle1;
	private Sprite Idle2;
	private Sprite Idle3;
	private Sprite Idle4;
	private Sprite Idle5;
	private Sprite Idle6;
	private Sprite Idle7;

	// Move
	private Sprite Move1;
	private Sprite Move2;
	private Sprite Move3;
	private Sprite Move4;
	private Sprite Move5;
	private Sprite Move6;
	private Sprite Move7;
	private Sprite Move8;

	// Flinch
	private Sprite Flinch;

	// Ability 
	private Sprite Ability1;
	private Sprite Ability2;
	private Sprite Ability3;
	private Sprite Ability4;
	private Sprite Ability5;
	private Sprite Ability6;
	private Sprite Ability7;
	private Sprite Ability8;
	private Sprite Ability9;
	private Sprite Ability10;
	private Sprite Ability11;

	// Special
	private Sprite Special1;
	private Sprite Special2;
	private Sprite Special3;
	private Sprite Special4;
	private Sprite Special5;
	private Sprite Special6;

	// Victory
	private Sprite Victory1;
	private Sprite Victory2;
	private Sprite Victory3;
	private Sprite Victory4;
	private Sprite Victory5;
	private Sprite Victory6;
	private Sprite Victory7;
	private Sprite Victory8;

	// Defeat
	private Sprite Defeat1;
	private Sprite Defeat2;
	private Sprite Defeat3;
	private Sprite Defeat4;
	private Sprite Defeat5;
	private Sprite Defeat6;
	private Sprite Defeat7;
	private Sprite Defeat8;
	private Sprite Defeat9;

	// Particles
	public GameObject BasicHitParticles;
	public GameObject SpecialHitParticles;
	public GameObject BlockParticles;
	public GameObject MissParticles;

	// Joycons

	private KeyCode JoyConKey_A;
	private KeyCode JoyConKey_B;
	private KeyCode JoyConKey_X;
	private KeyCode JoyConKey_Y;
	private KeyCode JoyConKey_SR;
	private KeyCode JoyConKey_SL;
	private KeyCode JoyConKey_JoyPressed1;
	private KeyCode JoyConKey_JoyPressed2;
	private float JoyConHorizontal = 0.0f;
	private float JoyConVertical = 0.0f;
	private Vector2 JoyConJoystick;

	private KeyCode PunchKey;
	private KeyCode JumpKey;
	private KeyCode AbilityKey;
	private KeyCode SpecialKey;
	private KeyCode BlockKey;
	private KeyCode CrouchKey;
	private float KeyHorizontal;
	private Vector2 KeyMovement;

	private bool canMove;
	private bool canJump;
	private bool canPunch;
	private float punchTimer = 0.0f;
	private bool abilityActivated;
	private float abilityTimer = 0.0f;
	public bool abilityAvailable;
	private bool specialActivated;
	private float specialTimer = 0.0f;
	private bool isBlocking;
	private bool isWalking;
	private bool isCrouched;
	private bool isJumping;
	private bool isAttacking;
	private float flinchTimer = 0.0f;
	private bool isFlinching;
	private float idleTimer = 0.0f;
	private float walkingTimer = 0.0f;
	private bool gameOver = false;
	private bool roundOver = false;
	private float roundTimer = 1.0f;
	private float gameOverTimer;

	private float basicAttackDamage = 2.5f;
	private float abilityDamage = 7.5f;
	private float specialDamage = 20.0f;

	private float damage_global;

	private float dashTimer = 0.0f;
	private bool dashed = false;

	// Use this for initialization
	void Start () {
		SetUpPlayerController ();
		CharacterSetUp ();
		sr = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
			
		if (player == 2 && GameManager.GM.character1 == GameManager.GM.character2) {
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

		if (player == 1 && GameManager.GM.character1 == "Alice") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(112.0f/255.0f, 22.0f/255.0f, 191.0f/255.0f, 255.0f/255.0f);
		} else if (player == 1 && GameManager.GM.character1 == "TheBeast") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(246.0f/255.0f, 183.0f/255.0f, 49.0f/255.0f, 255.0f/255.0f);
		} else if (player == 1 && GameManager.GM.character1 == "QueenOfHearts") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(191.0f/255.0f, 6.0f/255.0f, 6.0f/255.0f, 255.0f/255.0f);
		} else if (player == 2 && GameManager.GM.character2 == "Alice") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(112.0f/255.0f, 22.0f/255.0f, 191.0f/255.0f, 255.0f/255.0f);
		} else if (player == 2 && GameManager.GM.character2 == "TheBeast") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(246.0f/255.0f, 183.0f/255.0f, 49.0f/255.0f, 255.0f/255.0f);
		} else if (player == 2 && GameManager.GM.character2 == "QueenOfHearts") {
			ultimateGlow.GetComponent<SpriteRenderer>().color = new Color(191.0f/255.0f, 6.0f/255.0f, 6.0f/255.0f, 255.0f/255.0f);
		}
		ultimateGlow.SetActive(false);

		canMove = true;
		canJump = true;

		EventSystem.SetActive (false);
		rematch_button.SetActive (false);
		menu_button.SetActive (false);
		CharacterWin_txt.text = "";
		round_txt.text = "";

	}
	
	// Update is called once per frame
	void Update () {

		if (residue_health_timer > 0.0f) {
			residue_health_timer -= Time.deltaTime;
			if (residue_health_timer <= 0.0f) {
				residue_health_timer = 0.0f;
				previous_health = health;
				residue_health = health;
			} else {
				residue_health = health + ((previous_health - health) * (residue_health_timer / 0.75f));
			}
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			GameManager.GM.playe1wins = 0;
			GameManager.GM.playe2wins = 0;
			GameManager.GM.round = 1;
			SceneManager.LoadScene (1);
			SoundManager.S.StopBackgroundMusic ();
			SoundManager.S.PlayTitleMusic ();
		}

		//FindKeyCode ();
		if (!gameOver && !roundOver) {
			GetControllerInputsPlayer ();
			MovePlayer ();
		}

		if (health <= 0.0f && !gameOver) {
			if (GameManager.GM.round == 1) {
				roundOver = true;
				otherGO.GetComponent<PlayerController> ().roundOver = true;
				roundTimer -= Time.deltaTime;
				if (roundTimer <= 0.0f) {
					GameManager.GM.round++;
					if (player == 1) {
						GameManager.GM.playe2wins++;
					} else if (player == 2) {
						GameManager.GM.playe1wins++;
					}
					SceneManager.LoadScene (3);
				}
			} else if (GameManager.GM.round == 2) {
				if ((player == 1 && GameManager.GM.playe2wins == 1) || (player == 2 && GameManager.GM.playe1wins == 1)) {
					otherGO.GetComponent<PlayerController> ().gameOver = true;
					otherGO.GetComponent<PlayerController> ().gameOverTimer = 3.0f;
					otherGO.GetComponent<PlayerController>().PlaySound("quote");
					otherGO.GetComponent<PlayerController> ().sr.sprite = otherGO.GetComponent<PlayerController> ().Normal;
					gameOver = true;
					gameOverTimer = 3.0f;
					rb.velocity = Vector2.zero;
					otherGO.GetComponent<PlayerController> ().rb.velocity = Vector2.zero;
					sr.sprite = Normal;
					if (player == 1) {
						transform.position = new Vector3 (-4.3f, transform.position.y, .02f);
						otherGO.transform.position = new Vector3 (4.3f, otherGO.transform.position.y, .02f);
					} else {
						transform.position = new Vector3 (4.3f, transform.position.y, .02f);
						otherGO.transform.position = new Vector3 (-4.3f, otherGO.transform.position.y, .02f);
					}
					EventSystem.SetActive (true);
					rematch_button.SetActive (true);
					menu_button.SetActive (true);
					round_txt.text = "wins";

					if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "Alice") {
						CharacterWin_txt.text = "Alice";
					} else if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "TheBeast") {
						CharacterWin_txt.text = "The Beast";
					} else if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "QueenOfHearts") {
						CharacterWin_txt.text = "Queen Of Hearts";
					} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "Alice") {
						CharacterWin_txt.text = "Alice";
					} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "TheBeast") {
						CharacterWin_txt.text = "The Beast";
					} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "QueenOfHearts") {
						CharacterWin_txt.text = "Queen Of Hearts";
					}
				} else {
					roundOver = true;
					otherGO.GetComponent<PlayerController> ().roundOver = true;
					roundTimer -= Time.deltaTime;
					if (roundTimer <= 0.0f) {
						GameManager.GM.round++;
						if (player == 1) {
							GameManager.GM.playe2wins++;
						} else if (player == 2) {
							GameManager.GM.playe1wins++;
						}
						SceneManager.LoadScene (3);
					}
				}
			} else if (GameManager.GM.round == 3) {
				otherGO.GetComponent<PlayerController> ().gameOver = true;
				otherGO.GetComponent<PlayerController> ().gameOverTimer = 3.0f;
				otherGO.GetComponent<PlayerController>().PlaySound("quote");
				otherGO.GetComponent<PlayerController> ().sr.sprite = otherGO.GetComponent<PlayerController> ().Normal;
				gameOver = true;
				gameOverTimer = 3.0f;
				rb.velocity = Vector2.zero;
				otherGO.GetComponent<PlayerController> ().rb.velocity = Vector2.zero;
				sr.sprite = Normal;
				if (player == 1) {
					transform.position = new Vector3 (-4.3f, transform.position.y, .02f);
					otherGO.transform.position = new Vector3 (4.3f, otherGO.transform.position.y, .02f);
				} else {
					transform.position = new Vector3 (4.3f, transform.position.y, .02f);
					otherGO.transform.position = new Vector3 (-4.3f, otherGO.transform.position.y, .02f);
				}

				EventSystem.SetActive (true);
				rematch_button.SetActive (true);
				menu_button.SetActive (true);
				round_txt.text = "wins";

				if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "Alice") {
					CharacterWin_txt.text = "Alice";
				} else if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "TheBeast") {
					CharacterWin_txt.text = "The Beast";
				} else if (otherGO.GetComponent<PlayerController> ().player == 1 && GameManager.GM.character1 == "QueenOfHearts") {
					CharacterWin_txt.text = "Queen Of Hearts";
				} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "Alice") {
					CharacterWin_txt.text = "Alice";
				} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "TheBeast") {
					CharacterWin_txt.text = "The Beast";
				} else if (otherGO.GetComponent<PlayerController> ().player == 2 && GameManager.GM.character2 == "QueenOfHearts") {
					CharacterWin_txt.text = "Queen Of Hearts";
				}
			}

		}
			
		if (gameOver) {
			if (health <= 0.0f) {
				gameOverTimer -= Time.deltaTime;
				if (gameOverTimer <= 0.2f) {
					sr.sprite = Defeat9;
				} else if (gameOverTimer <= 0.4f) {
					sr.sprite = Defeat9;
				} else if (gameOverTimer <= 0.6f) {
					sr.sprite = Defeat8;
				} else if (gameOverTimer <= 0.8f) {
					sr.sprite = Defeat7;
				} else if (gameOverTimer <= 1.0f) {
					sr.sprite = Defeat6;
				} else if (gameOverTimer <= 1.2f) {
					sr.sprite = Defeat5;
				} else if (gameOverTimer <= 1.4f) {
					sr.sprite = Defeat4;
				} else if (gameOverTimer <= 1.6f) {
					sr.sprite = Defeat3;
				} else if (gameOverTimer <= 1.8f) {
					sr.sprite = Defeat2;
				} else if (gameOverTimer <= 2.0f) {
					sr.sprite = Defeat1;
				}
				changedSprite = true;
			} else {
				gameOverTimer -= Time.deltaTime;
				if (gameOverTimer <= 0.2f) {
					sr.sprite = Victory8;
				} else if (gameOverTimer <= 0.4f) {
					sr.sprite = Victory8;
				} else if (gameOverTimer <= 0.6f) {
					sr.sprite = Victory7;
				} else if (gameOverTimer <= 0.8f) {
					sr.sprite = Victory6;
				} else if (gameOverTimer <= 1.0f) {
					sr.sprite = Victory5;
				} else if (gameOverTimer <= 1.2f) {
					sr.sprite = Victory4;
				} else if (gameOverTimer <= 1.4f) {
					sr.sprite = Victory4;
				} else if (gameOverTimer <= 1.6f) {
					sr.sprite = Victory3;
				} else if (gameOverTimer <= 1.8f) {
					sr.sprite = Victory2;
				} else if (gameOverTimer <= 2.0f) {
					sr.sprite = Victory1;
				}
				changedSprite = true;
			}
		}

		if (transform.position.x < otherGO.transform.position.x) {
			if ((player == 1 && (GameManager.GM.character1 == "Alice" || GameManager.GM.character1 == "QueenOfHearts") || 
				(player == 2 && (GameManager.GM.character2 == "Alice" || GameManager.GM.character2 == "QueenOfHearts")))) {
				sr.flipX = true;

			} else {
				sr.flipX = false;
			}
			basicAttackCollider.transform.localPosition = new Vector3 (Mathf.Abs (basicAttackCollider.transform.localPosition.x),
				basicAttackCollider.transform.localPosition.y, basicAttackCollider.transform.localPosition.z);
		} else {
			if ((player == 1 && (GameManager.GM.character1 == "Alice" || GameManager.GM.character1 == "QueenOfHearts") || 
				(player == 2 && (GameManager.GM.character2 == "Alice" || GameManager.GM.character2 == "QueenOfHearts")))) {
				sr.flipX = false;

			} else {
				sr.flipX = true;
			}
			basicAttackCollider.transform.localPosition = new Vector3 (-1.0f * Mathf.Abs (basicAttackCollider.transform.localPosition.x),
				basicAttackCollider.transform.localPosition.y, basicAttackCollider.transform.localPosition.z);
		}
			
		if (!changedSprite) {
			sr.sprite = Normal;
		}
		changedSprite = false;
	}

	private void MovePlayer () {
		if (isBlocking && canMove && !dashed) {
			rb.velocity = new Vector2((((JoyConJoystick.x + KeyMovement.x) * 0.0f) * speed), rb.velocity.y);
		}
		else if (canMove && !dashed) {
			rb.velocity = new Vector2(((JoyConJoystick.x + KeyMovement.x) * speed), rb.velocity.y);
		}
	}

	private void SetUpPlayerController () {
		if (player == 1) {

			JoyConKey_A = KeyCode.Joystick1Button0;
			JoyConKey_B = KeyCode.Joystick1Button2;
			JoyConKey_X = KeyCode.Joystick1Button1;
			JoyConKey_Y = KeyCode.Joystick1Button3;

			JoyConKey_SR = KeyCode.Joystick1Button5;
			JoyConKey_SL = KeyCode.Joystick1Button4;

			JoyConKey_JoyPressed1 = KeyCode.Joystick1Button11;
			JoyConKey_JoyPressed2 = KeyCode.Joystick1Button10;

			PunchKey = KeyCode.Tab;
			JumpKey = KeyCode.W;
			AbilityKey = KeyCode.Z;
			SpecialKey = KeyCode.X;
			BlockKey = KeyCode.LeftShift;
			CrouchKey = KeyCode.S;


		} else {

			JoyConKey_A = KeyCode.Joystick2Button0;
			JoyConKey_B = KeyCode.Joystick2Button2;
			JoyConKey_X = KeyCode.Joystick2Button1;
			JoyConKey_Y = KeyCode.Joystick2Button3;

			JoyConKey_SR = KeyCode.Joystick2Button5;
			JoyConKey_SL = KeyCode.Joystick2Button4;

			JoyConKey_JoyPressed2 = KeyCode.Joystick2Button10;
			JoyConKey_JoyPressed1 = KeyCode.Joystick2Button11;

			PunchKey = KeyCode.Space;
			JumpKey = KeyCode.UpArrow;
			AbilityKey = KeyCode.RightShift;
			SpecialKey = KeyCode.Slash;
			BlockKey = KeyCode.Return;
			CrouchKey = KeyCode.DownArrow;

		}
	}

	private void CharacterSetUp () {
		if (player == 1) {
			if (GameManager.GM.character1 == "Alice") {

				GetComponent<CapsuleCollider2D> ().size = new Vector2 (2.19f, 5.5f);
				basicAttackCollider.transform.localPosition = new Vector3 (2.5f, 0.0f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 0.75f;
				transform.position = new Vector3 (-4.3f, -0.5f, 0.02f);

				Normal = AliceNormal;
				Block = AliceBlock;
				Crouch = AliceCrouch;

				// Dash
				DashForward = AliceDashForward;
				DashBack = AliceDashBack;

				// Jump
				Jump1 = AliceJump1;
				Jump2 = AliceJump2;
				Jump3 = AliceJump3;
				Jump4 = AliceJump4;

				// Basic Attack
				Punch1 = AlicePunch1;
				Punch2 = AlicePunch2;
				Punch3 = AlicePunch3;
				Punch4 = AlicePunch4;

				// Idle
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;

				// Move
				Move1 = AliceMove1;
				Move2 = AliceMove2;
				Move3 = AliceMove3;
				Move4 = AliceMove4;
				Move5 = AliceMove5;
				Move6 = AliceMove6;
				Move7 = AliceMove7;
				Move8 = AliceMove8;

				// Flinch
				Flinch = AliceFlinch;

				// Ability 
				Ability1 = AliceAbility1;
				Ability2 = AliceAbility2;
				Ability3 = AliceAbility3;
				Ability4 = AliceAbility4;
				Ability5 = AliceAbility5;
				Ability6 = AliceAbility6;
				Ability7 = AliceAbility7;
				Ability8 = AliceAbility8;
				Ability9 = AliceAbility9;
				Ability10 = AliceAbility10;
				Ability11 = AliceAbility11;

				// Special
				Special1 = AliceSpecial1;
				Special2 = AliceSpecial2;
				Special3 = AliceSpecial3;
				Special4 = AliceSpecial4;
				Special5 = AliceSpecial5;
				Special6 = AliceSpecial6;

				// Victory
				Victory1 = AliceVictory1;
				Victory2 = AliceVictory2;
				Victory3 = AliceVictory3;
				Victory4 = AliceVictory4;
				Victory5 = AliceVictory5;
				Victory6 = AliceVictory6;
				Victory7 = AliceVictory7;
				Victory8 = AliceVictory8;

				// Defeat
				Defeat1 = AliceDefeat1;
				Defeat2 = AliceDefeat2;
				Defeat3 = AliceDefeat3;
				Defeat4 = AliceDefeat4;
				Defeat5 = AliceDefeat5;
				Defeat6 = AliceDefeat6;
				Defeat7 = AliceDefeat7;
				Defeat8 = AliceDefeat8;
				Defeat9 = AliceDefeat9;

				// Particles
				BasicHitParticles = AliceBasicHitParticles;
				SpecialHitParticles = AliceSpecialHitParticles;
				BlockParticles = AliceBlockParticles;
				MissParticles = AliceMissParticles;

			} else if (GameManager.GM.character1 == "TheBeast") {
				GetComponent<CapsuleCollider2D> ().size = new Vector2 (4.0f, 8.73f);
				basicAttackCollider.transform.localPosition = new Vector3 (2.5f, 0.5f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 2.0f;
				transform.position = new Vector3 (-4.3f, 0.51f, 0.02f);

				Normal = BeastNormal;
				Block = BeastBlock;
				Crouch = BeastCrouch;

				// Dash
				DashForward = BeastDashForward;
				DashBack = BeastDashBack;

				// Jump
				Jump1 = BeastJump1;
				Jump2 = BeastJump2;
				Jump3 = BeastJump3;
				Jump4 = BeastJump4;

				// Basic Attack
				Punch1 = BeastPunch1;
				Punch2 = BeastPunch2;
				Punch3 = BeastPunch3;
				Punch4 = BeastPunch4;

				// Idle
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;

				// Move
				Move1 = BeastMove1;
				Move2 = BeastMove2;
				Move3 = BeastMove3;
				Move4 = BeastMove4;
				Move5 = BeastMove5;
				Move6 = BeastMove6;
				Move7 = BeastMove7;
				Move8 = BeastMove8;

				// Flinch
				Flinch = BeastFlinch;

				// Ability 
				Ability1 = BeastAbility1;
				Ability2 = BeastAbility2;
				Ability3 = BeastAbility3;
				Ability4 = BeastAbility4;
				Ability5 = BeastAbility5;
				Ability6 = BeastAbility6;
				Ability7 = BeastAbility7;
				Ability8 = BeastAbility8;
				Ability9 = BeastAbility9;
				Ability10 = BeastAbility10;
				Ability11 = BeastAbility11;

				// Special
				Special1 = BeastSpecial1;
				Special2 = BeastSpecial2;
				Special3 = BeastSpecial3;
				Special4 = BeastSpecial4;
				Special5 = BeastSpecial5;
				Special6 = BeastSpecial6;

				// Victory
				Victory1 = BeastVictory1;
				Victory2 = BeastVictory2;
				Victory3 = BeastVictory3;
				Victory4 = BeastVictory4;
				Victory5 = BeastVictory5;
				Victory6 = BeastVictory6;
				Victory7 = BeastVictory7;
				Victory8 = BeastVictory8;

				// Defeat
				Defeat1 = BeastDefeat1;
				Defeat2 = BeastDefeat2;
				Defeat3 = BeastDefeat3;
				Defeat4 = BeastDefeat4;
				Defeat5 = BeastDefeat5;
				Defeat6 = BeastDefeat6;
				Defeat7 = BeastDefeat7;
				Defeat8 = BeastDefeat8;
				Defeat9 = BeastDefeat9;

				// Particles
				BasicHitParticles = BeastBasicHitParticles;
				SpecialHitParticles = BeastSpecialHitParticles;
				BlockParticles = BeastBlockParticles;
				MissParticles = BeastMissParticles;

			} else if (GameManager.GM.character1 == "QueenOfHearts") {
				
				GetComponent<CapsuleCollider2D> ().size = new Vector2 (2.0f, 8.73f);
				basicAttackCollider.transform.localPosition = new Vector3 (3f, 0.5f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 2f;
				transform.position = new Vector3 (-4.3f, 0.51f, 0.02f);

				Normal = QueenNormal;
				Block = QueenBlock;
				Crouch = QueenCrouch;

				// Dash
				DashForward = QueenDashForward;
				DashBack = QueenDashBack;

				// Jump
				Jump1 = QueenJump1;
				Jump2 = QueenJump2;
				Jump3 = QueenJump3;
				Jump4 = QueenJump4;

				// Basic Attack
				Punch1 = QueenPunch1;
				Punch2 = QueenPunch2;
				Punch3 = QueenPunch3;
				Punch4 = QueenPunch4;

				// Idle
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;

				// Move
				Move1 = QueenMove1;
				Move2 = QueenMove2;
				Move3 = QueenMove3;
				Move4 = QueenMove4;
				Move5 = QueenMove5;
				Move6 = QueenMove6;
				Move7 = QueenMove7;
				Move8 = QueenMove8;

				// Flinch
				Flinch = QueenFlinch;

				// Ability 
				Ability1 = QueenAbility1;
				Ability2 = QueenAbility2;
				Ability3 = QueenAbility3;
				Ability4 = QueenAbility4;
				Ability5 = QueenAbility5;
				Ability6 = QueenAbility6;
				Ability7 = QueenAbility7;
				Ability8 = QueenAbility8;
				Ability9 = QueenAbility9;
				Ability10 = QueenAbility10;
				Ability11 = QueenAbility11;

				// Special
				Special1 = QueenSpecial1;
				Special2 = QueenSpecial2;
				Special3 = QueenSpecial3;
				Special4 = QueenSpecial4;
				Special5 = QueenSpecial5;
				Special6 = QueenSpecial6;

				// Victory
				Victory1 = QueenVictory1;
				Victory2 = QueenVictory2;
				Victory3 = QueenVictory3;
				Victory4 = QueenVictory4;
				Victory5 = QueenVictory5;
				Victory6 = QueenVictory6;
				Victory7 = QueenVictory7;
				Victory8 = QueenVictory8;

				// Defeat
				Defeat1 = QueenDefeat1;
				Defeat2 = QueenDefeat2;
				Defeat3 = QueenDefeat3;
				Defeat4 = QueenDefeat4;
				Defeat5 = QueenDefeat5;
				Defeat6 = QueenDefeat6;
				Defeat7 = QueenDefeat7;
				Defeat8 = QueenDefeat8;
				Defeat9 = QueenDefeat9;

				// Particles
				BasicHitParticles = QueenBasicHitParticles;
				SpecialHitParticles = QueenSpecialHitParticles;
				BlockParticles = QueenBlockParticles;
				MissParticles = QueenMissParticles;
			}

		} else if (player == 2) {
			if (GameManager.GM.character2 == "Alice") {
				GetComponent<CapsuleCollider2D> ().size = new Vector2 (2.19f, 5.5f);
				basicAttackCollider.transform.localPosition = new Vector3 (-2.5f, 0.0f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 0.75f;
				transform.position = new Vector3 (4.3f, -0.5f, 0.02f);

				Normal = AliceNormal;
				Block = AliceBlock;
				Crouch = AliceCrouch;

				// Dash
				DashForward = AliceDashForward;
				DashBack = AliceDashBack;

				// Jump
				Jump1 = AliceJump1;
				Jump2 = AliceJump2;
				Jump3 = AliceJump3;
				Jump4 = AliceJump4;

				// Basic Attack
				Punch1 = AlicePunch1;
				Punch2 = AlicePunch2;
				Punch3 = AlicePunch3;
				Punch4 = AlicePunch4;

				// Idle
				Idle1 = AliceIdle1;
				Idle2 = AliceIdle2;
				Idle3 = AliceIdle3;
				Idle4 = AliceIdle4;
				Idle5 = AliceIdle5;
				Idle6 = AliceIdle6;
				Idle7 = AliceIdle7;

				// Move
				Move1 = AliceMove1;
				Move2 = AliceMove2;
				Move3 = AliceMove3;
				Move4 = AliceMove4;
				Move5 = AliceMove5;
				Move6 = AliceMove6;
				Move7 = AliceMove7;
				Move8 = AliceMove8;

				// Flinch
				Flinch = AliceFlinch;

				// Ability 
				Ability1 = AliceAbility1;
				Ability2 = AliceAbility2;
				Ability3 = AliceAbility3;
				Ability4 = AliceAbility4;
				Ability5 = AliceAbility5;
				Ability6 = AliceAbility6;
				Ability7 = AliceAbility7;
				Ability8 = AliceAbility8;
				Ability9 = AliceAbility9;
				Ability10 = AliceAbility10;
				Ability11 = AliceAbility11;

				// Special
				Special1 = AliceSpecial1;
				Special2 = AliceSpecial2;
				Special3 = AliceSpecial3;
				Special4 = AliceSpecial4;
				Special5 = AliceSpecial5;
				Special6 = AliceSpecial6;

				// Victory
				Victory1 = AliceVictory1;
				Victory2 = AliceVictory2;
				Victory3 = AliceVictory3;
				Victory4 = AliceVictory4;
				Victory5 = AliceVictory5;
				Victory6 = AliceVictory6;
				Victory7 = AliceVictory7;
				Victory8 = AliceVictory8;

				// Defeat
				Defeat1 = AliceDefeat1;
				Defeat2 = AliceDefeat2;
				Defeat3 = AliceDefeat3;
				Defeat4 = AliceDefeat4;
				Defeat5 = AliceDefeat5;
				Defeat6 = AliceDefeat6;
				Defeat7 = AliceDefeat7;
				Defeat8 = AliceDefeat8;
				Defeat9 = AliceDefeat9;

				// Particles
				BasicHitParticles = AliceBasicHitParticles;
				SpecialHitParticles = AliceSpecialHitParticles;
				BlockParticles = AliceBlockParticles;
				MissParticles = AliceMissParticles;

			} else if (GameManager.GM.character2 == "TheBeast") {
				GetComponent<CapsuleCollider2D> ().size = new Vector2 (4.0f, 8.73f);
				basicAttackCollider.transform.localPosition = new Vector3 (-2.5f, 0.5f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 2.0f;
				transform.position = new Vector3 (4.3f, 0.51f, 0.02f);

				Normal = BeastNormal;
				Block = BeastBlock;
				Crouch = BeastCrouch;

				// Dash
				DashForward = BeastDashForward;
				DashBack = BeastDashBack;

				// Jump
				Jump1 = BeastJump1;
				Jump2 = BeastJump2;
				Jump3 = BeastJump3;
				Jump4 = BeastJump4;

				// Basic Attack
				Punch1 = BeastPunch1;
				Punch2 = BeastPunch2;
				Punch3 = BeastPunch3;
				Punch4 = BeastPunch4;

				// Idle
				Idle1 = BeastIdle1;
				Idle2 = BeastIdle2;
				Idle3 = BeastIdle3;
				Idle4 = BeastIdle4;
				Idle5 = BeastIdle5;
				Idle6 = BeastIdle6;
				Idle7 = BeastIdle7;

				// Move
				Move1 = BeastMove1;
				Move2 = BeastMove2;
				Move3 = BeastMove3;
				Move4 = BeastMove4;
				Move5 = BeastMove5;
				Move6 = BeastMove6;
				Move7 = BeastMove7;
				Move8 = BeastMove8;

				// Flinch
				Flinch = BeastFlinch;

				// Ability 
				Ability1 = BeastAbility1;
				Ability2 = BeastAbility2;
				Ability3 = BeastAbility3;
				Ability4 = BeastAbility4;
				Ability5 = BeastAbility5;
				Ability6 = BeastAbility6;
				Ability7 = BeastAbility7;
				Ability8 = BeastAbility8;
				Ability9 = BeastAbility9;
				Ability10 = BeastAbility10;
				Ability11 = BeastAbility11;

				// Special
				Special1 = BeastSpecial1;
				Special2 = BeastSpecial2;
				Special3 = BeastSpecial3;
				Special4 = BeastSpecial4;
				Special5 = BeastSpecial5;
				Special6 = BeastSpecial6;

				// Victory
				Victory1 = BeastVictory1;
				Victory2 = BeastVictory2;
				Victory3 = BeastVictory3;
				Victory4 = BeastVictory4;
				Victory5 = BeastVictory5;
				Victory6 = BeastVictory6;
				Victory7 = BeastVictory7;
				Victory8 = BeastVictory8;

				// Defeat
				Defeat1 = BeastDefeat1;
				Defeat2 = BeastDefeat2;
				Defeat3 = BeastDefeat3;
				Defeat4 = BeastDefeat4;
				Defeat5 = BeastDefeat5;
				Defeat6 = BeastDefeat6;
				Defeat7 = BeastDefeat7;
				Defeat8 = BeastDefeat8;
				Defeat9 = BeastDefeat9;

				// Particles
				BasicHitParticles = BeastBasicHitParticles;
				SpecialHitParticles = BeastSpecialHitParticles;
				BlockParticles = BeastBlockParticles;
				MissParticles = BeastMissParticles;

			} else if (GameManager.GM.character2 == "QueenOfHearts") {
				GetComponent<CapsuleCollider2D> ().size = new Vector2 (2.0f, 8.73f);
				basicAttackCollider.transform.localPosition = new Vector3 (-3f, 0.5f, 0.0f);
				basicAttackCollider.GetComponent<CircleCollider2D> ().radius = 2f;
				transform.position = new Vector3 (4.3f, 0.51f, 0.02f);

				Normal = QueenNormal;
				Block = QueenBlock;
				Crouch = QueenCrouch;

				// Dash
				DashForward = QueenDashForward;
				DashBack = QueenDashBack;

				// Jump
				Jump1 = QueenJump1;
				Jump2 = QueenJump2;
				Jump3 = QueenJump3;
				Jump4 = QueenJump4;

				// Basic Attack
				Punch1 = QueenPunch1;
				Punch2 = QueenPunch2;
				Punch3 = QueenPunch3;
				Punch4 = QueenPunch4;

				// Idle
				Idle1 = QueenIdle1;
				Idle2 = QueenIdle2;
				Idle3 = QueenIdle3;
				Idle4 = QueenIdle4;
				Idle5 = QueenIdle5;
				Idle6 = QueenIdle6;
				Idle7 = QueenIdle7;

				// Move
				Move1 = QueenMove1;
				Move2 = QueenMove2;
				Move3 = QueenMove3;
				Move4 = QueenMove4;
				Move5 = QueenMove5;
				Move6 = QueenMove6;
				Move7 = QueenMove7;
				Move8 = QueenMove8;

				// Flinch
				Flinch = QueenFlinch;

				// Ability 
				Ability1 = QueenAbility1;
				Ability2 = QueenAbility2;
				Ability3 = QueenAbility3;
				Ability4 = QueenAbility4;
				Ability5 = QueenAbility5;
				Ability6 = QueenAbility6;
				Ability7 = QueenAbility7;
				Ability8 = QueenAbility8;
				Ability9 = QueenAbility9;
				Ability10 = QueenAbility10;
				Ability11 = QueenAbility11;

				// Special
				Special1 = QueenSpecial1;
				Special2 = QueenSpecial2;
				Special3 = QueenSpecial3;
				Special4 = QueenSpecial4;
				Special5 = QueenSpecial5;
				Special6 = QueenSpecial6;

				// Victory
				Victory1 = QueenVictory1;
				Victory2 = QueenVictory2;
				Victory3 = QueenVictory3;
				Victory4 = QueenVictory4;
				Victory5 = QueenVictory5;
				Victory6 = QueenVictory6;
				Victory7 = QueenVictory7;
				Victory8 = QueenVictory8;

				// Defeat
				Defeat1 = QueenDefeat1;
				Defeat2 = QueenDefeat2;
				Defeat3 = QueenDefeat3;
				Defeat4 = QueenDefeat4;
				Defeat5 = QueenDefeat5;
				Defeat6 = QueenDefeat6;
				Defeat7 = QueenDefeat7;
				Defeat8 = QueenDefeat8;
				Defeat9 = QueenDefeat9;

				// Particles
				BasicHitParticles = QueenBasicHitParticles;
				SpecialHitParticles = QueenSpecialHitParticles;
				BlockParticles = QueenBlockParticles;
				MissParticles = QueenMissParticles;
			}
		}
	}

	private void FindKeyCode() {
		for (KeyCode i = 0; i <= KeyCode.Joystick8Button19; i++)
		{
			if (Input.GetKey(i))
				Debug.Log(i);
		}
	}

	private void PlaySound(string sound) {
		if (player == 1) {
			if (GameManager.GM.character1 == "Alice") {
				if (sound == "attack") {
					SoundManager.S.PlayAliceAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayAliceBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayAliceJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayAliceFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayAliceAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayAliceSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayAliceQuoteSound ();
				}
			} else if (GameManager.GM.character1 == "TheBeast") {
				if (sound == "attack") {
					SoundManager.S.PlayBeastAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayBeastBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayBeastJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayBeastFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayBeastAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayBeastSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayBeastQuoteSound ();
				}
			} else if (GameManager.GM.character1 == "QueenOfHearts") {
				if (sound == "attack") {
					SoundManager.S.PlayQueenAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayQueenBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayQueenJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayQueenFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayQueenAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayQueenSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayQueenQuoteSound ();
				}
			} 
		} else {
			if (GameManager.GM.character2 == "Alice") {
				if (sound == "attack") {
					SoundManager.S.PlayAliceAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayAliceBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayAliceJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayAliceFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayAliceAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayAliceSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayAliceQuoteSound ();
				}
			} else if (GameManager.GM.character2 == "TheBeast") {
				if (sound == "attack") {
					SoundManager.S.PlayBeastAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayBeastBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayBeastJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayBeastFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayBeastAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayBeastSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayBeastQuoteSound ();
				}
			} else if (GameManager.GM.character2 == "QueenOfHearts") {
				if (sound == "attack") {
					SoundManager.S.PlayQueenAttackSound ();
				} else if (sound == "block") {
					SoundManager.S.PlayQueenBlockSound ();
				} else if (sound == "jump") {
					SoundManager.S.PlayQueenJumpSound ();
				} else if (sound == "flinch") {
					SoundManager.S.PlayQueenFlinchSound ();
				} else if (sound == "ability") {
					SoundManager.S.PlayQueenAbilitySound ();
				} else if (sound == "special") {
					SoundManager.S.PlayQueenSpecialSound ();
				} else if (sound == "quote") {
					SoundManager.S.PlayQueenQuoteSound ();
				}
			} 
		}
	}

	private void GetControllerInputsPlayer () {

		GetJoystickAxis ();

		isBlocking = false;

		if (canMove) {
			if (Input.GetKey (JoyConKey_JoyPressed1) || Input.GetKey(JoyConKey_JoyPressed2) || Input.GetKey (BlockKey)) {
				isBlocking = true;
				sr.sprite = Block;
				changedSprite = true;
			} else if ((Input.GetKeyDown (JoyConKey_X) || Input.GetKeyDown (PunchKey)) && canPunch && !isBlocking) {
				canPunch = false;
				punchTimer = 0.4f;
				PlaySound ("attack");
			} else if ((Input.GetKeyDown (JoyConKey_A) || Input.GetKeyDown (JumpKey)) && canJump) {
				canJump = false;
				rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
				sr.sprite = Jump1;
				PlaySound ("jump");
			} else if ((Input.GetKeyDown (JoyConKey_Y) || Input.GetKeyDown (AbilityKey)) && !dashed && !isBlocking) {
				dashed = true;
				dashTimer = 0.2f;
				changedSprite = true;
				if (JoyConHorizontal > 0.0f) {
					rb.velocity = new Vector2 (dashSpeed, rb.velocity.y);
					sr.sprite = DashForward;
				} else if (JoyConHorizontal < 0.0f) {
					sr.sprite = DashBack;
					rb.velocity = new Vector2 (-dashSpeed, rb.velocity.y);
				} else {
					if (transform.position.x < otherGO.transform.position.x) {
						sr.sprite = DashForward;
						rb.velocity = new Vector2 (dashSpeed, rb.velocity.y);
					} else {
						sr.sprite = DashBack;
						rb.velocity = new Vector2 (-dashSpeed, rb.velocity.y);
					}
				}
			} else if ((Input.GetKeyDown (JoyConKey_B) || Input.GetKeyDown (AbilityKey)) && !abilityActivated && abilityAvailable) {
				canMove = false;
				abilityActivated = true;
				abilityTimer = 1.0f;
				rb.constraints = RigidbodyConstraints2D.FreezeAll;
				if ((transform.position - otherGO.transform.position).magnitude < 4.5f) {
					otherGO.GetComponent<PlayerController>().TakeDamage(abilityDamage, 0.9f);
					Instantiate(SpecialHitParticles, otherGO.transform.position, Quaternion.identity);
				} else {
					Instantiate(MissParticles, (otherGO.transform.position + transform.position) / 2.0f, Quaternion.identity);
				}
				abilityAvailable = false;
				PlaySound ("ability");
			} else if ((Input.GetKey (JoyConKey_SL) && Input.GetKey (JoyConKey_SR) || Input.GetKey (SpecialKey)) && !specialActivated && special >= 100.0f) {
				special = 0.0f;
				ultimateGlow.SetActive(false);
				if ((transform.position - otherGO.transform.position).magnitude < 5.0f) {
					otherGO.GetComponent<PlayerController>().TakeDamage(specialDamage, 1.5f);
					canMove = false;
					specialActivated = true;
					specialTimer = 1.5f;
					if ((player == 1 && GameManager.GM.character1 == "Alice") || (player == 2 && GameManager.GM.character2 == "Alice")) {
						transform.position = new Vector3(otherGO.transform.position.x, 2.0f, transform.position.z);
						transform.localScale = new Vector3(2.1f, 2.1f, transform.localScale.z);
					}
					queenChangeSize = true;
					rb.constraints = RigidbodyConstraints2D.FreezeAll;
					Instantiate(SpecialHitParticles, otherGO.transform.position, Quaternion.identity);
				} else {
					Instantiate(MissParticles, (otherGO.transform.position + transform.position) / 2.0f, Quaternion.identity);
				}
				PlaySound ("special");
			} else if ((JoyConVertical < -.5f || Input.GetKeyDown (CrouchKey)) && canJump && !isBlocking) {
				isCrouched = true;
				sr.sprite = Crouch;
				changedSprite = true;
			}
		}

		if (dashed) {
			dashTimer -= Time.deltaTime;
			if (dashTimer <= 0.0f) {
				dashed = false;
			}
		}

		if (canJump && rb.velocity.x == 0.0f && !isCrouched) {
			idleTimer -= Time.deltaTime;
			if (idleTimer <= 0.0f) {
				idleTimer = 0.8f;
				sr.sprite = Idle7;
			} else if (idleTimer <= 0.1f) {
				sr.sprite = Idle6;
			} else if (idleTimer <= 0.2f) {
				sr.sprite = Idle5;
			} else if (idleTimer <= 0.3f) {
				sr.sprite = Idle4;
			} else if (idleTimer <= 0.4f) {
				sr.sprite = Idle3;
			} else if (idleTimer <= 0.5f) {
				sr.sprite = Idle2;
			} else if (idleTimer <= 0.6f) {
				sr.sprite = Idle1;
			}
			changedSprite = true;
		}

		if (canJump && rb.velocity.x != 0.0f) {
			if (!isCrouched) {
				walkingTimer -= Time.deltaTime;
				if (walkingTimer <= 0.0f) {
					walkingTimer = 0.8f;
					sr.sprite = Move8;
				} else if (walkingTimer <= 0.1f) {
					sr.sprite = Move7;
				} else if (walkingTimer <= 0.2f) {
					sr.sprite = Move6;
				} else if (walkingTimer <= 0.3f) {
					sr.sprite = Move5;
				} else if (walkingTimer <= 0.4f) {
					sr.sprite = Move4;
				} else if (walkingTimer <= 0.5f) {
					sr.sprite = Move3;
				} else if (walkingTimer <= 0.6f) {
					sr.sprite = Move2;
				} else if (walkingTimer <= 0.7f) {
					sr.sprite = Move1;
				}
				changedSprite = true;
			} else {
				walkingTimer -= Time.deltaTime;
				if (walkingTimer <= 0.0f) {
					walkingTimer = 0.8f;
					sr.sprite = Crouch;
				} else if (walkingTimer <= 0.2f) {
					sr.sprite = Crouch;
				} else if (walkingTimer <= 0.4f) {
					sr.sprite = Crouch;
				} else if (walkingTimer <= 0.6f) {
					sr.sprite = Crouch;
				}
				changedSprite = true;
			}
		}

		if (!canJump) {
			if (rb.velocity.y < jumpSpeed / -2.0f) {
				sr.sprite = Jump4;
			} else if (rb.velocity.y < 0.0f) {
				sr.sprite = Jump3;
			} else if (rb.velocity.y < jumpSpeed / 2.0f) {
				sr.sprite = Jump2;
			}
			changedSprite = true;
		}

		if (!canPunch) {
			punchTimer -= Time.deltaTime;
			if (punchTimer <= 0.0f) {
				otherGO.transform.position = new Vector3 (otherGO.transform.position.x, otherGO.transform.position.y, otherGO.transform.position.z - .01f);				canPunch = true;
				basicAttackCollider.transform.position -= new Vector3 (0.0f, 0.01f, 0.0f);
				basicAttackCollider.gameObject.SetActive (false);
			} else if (punchTimer <= 0.1f) {
				sr.sprite = Punch4;
				changedSprite = true;
			} else if (punchTimer <= 0.2f) {
				sr.sprite = Punch3;
				changedSprite = true;
			} else if (punchTimer <= 0.3f) {
				sr.sprite = Punch2;
				changedSprite = true;
			} else if (punchTimer <= 0.4f) {
				sr.sprite = Punch1;
				changedSprite = true;
				basicAttackCollider.SetActive (true);
				basicAttackCollider.transform.position += new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
		if (abilityActivated) {
			abilityTimer -= Time.deltaTime;
			if (abilityTimer <= 0.0f) {
				otherGO.transform.position = new Vector3 (otherGO.transform.position.x, otherGO.transform.position.y, otherGO.transform.position.z - .01f);				abilityActivated = false;
				canMove = true;
				rb.constraints = RigidbodyConstraints2D.FreezeRotation;
				visualCooldownTimer.GetComponent<TimerController> ().SetTimer ();
			}  else if (abilityTimer <= 0.09f) {
				sr.sprite = Ability11;
				changedSprite = true;
			} else if (abilityTimer <= 0.18f) {
				sr.sprite = Ability10;
				changedSprite = true;
			} else if (abilityTimer <= 0.27f) {
				sr.sprite = Ability9;
				changedSprite = true;
			} else if (abilityTimer <= 0.36f) {
				sr.sprite = Ability8;
				changedSprite = true;
			} else if (abilityTimer <= 0.45f) {
				sr.sprite = Ability7;
				changedSprite = true;
			} else if (abilityTimer <= 0.54f) {
				sr.sprite = Ability6;
				changedSprite = true;
			} else if (abilityTimer <= 0.63f) {
				sr.sprite = Ability5;
				changedSprite = true;
			} else if (abilityTimer <= 0.72f) {
				sr.sprite = Ability4;
				changedSprite = true;
			} else if (abilityTimer <= 0.81f) {
				sr.sprite = Ability3;
				changedSprite = true;
			} else if (abilityTimer <= 0.9f) {
				sr.sprite = Ability2;
				changedSprite = true;
			} else if (abilityTimer <= 1.0f) {
				sr.sprite = Ability1;
				changedSprite = true;
			}
		}
		if (specialActivated) {
			specialTimer -= Time.deltaTime;
			if (specialTimer <= 0.0f) {
				otherGO.transform.position = new Vector3 (otherGO.transform.position.x, otherGO.transform.position.y, otherGO.transform.position.z - .01f);
				specialActivated = false;
				canMove = true;
				if ((player == 1 && GameManager.GM.character1 == "Alice") || (player == 2 && GameManager.GM.character2 == "Alice")) {
					transform.position = new Vector3 (transform.position.x, -0.53f, transform.position.z);
					transform.localScale = new Vector3 (0.7f, 0.7f, transform.localScale.z);
				} else if ((player == 1 && GameManager.GM.character1 == "QueenOfHearts") || (player == 2 && GameManager.GM.character2 == "QueenOfHearts")) {
					transform.position = new Vector3 (transform.position.x, .5f, transform.position.z);
					transform.localScale = new Vector3 (0.7f, 0.7f, transform.localScale.z);
					GetComponent<CapsuleCollider2D> ().enabled = true;
				}
				rb.constraints = RigidbodyConstraints2D.FreezeRotation;
			}  else if (specialTimer <= 0.2f) {
				sr.sprite = Special6;
				changedSprite = true;
			} else if (specialTimer <= 0.4f) {
				sr.sprite = Special5;
				changedSprite = true;
			} else if (specialTimer <= 0.6f) {
				sr.sprite = Special4;
				changedSprite = true;
				if (queenChangeSize) {
					queenChangeSize = false;
					if ((player == 1 && GameManager.GM.character1 == "QueenOfHearts") || (player == 2 && GameManager.GM.character2 == "QueenOfHearts")) {
						transform.position = new Vector3 (otherGO.transform.position.x, 2.0f, transform.position.z);
						transform.localScale = new Vector3 (1.7f, 1.7f, transform.localScale.z);
						otherGO.GetComponent<PlayerController> ().rb.velocity = new Vector2 (0.0f, rb.velocity.y);
						GetComponent<CapsuleCollider2D> ().enabled = false;
					}
				}
			} else if (specialTimer <= 0.8f) {
				sr.sprite = Special3;
				changedSprite = true;
			} else if (specialTimer <= 1.1f) {
				sr.sprite = Special2;
				changedSprite = true;
			} else if (specialTimer <= 1.5f) {
				sr.sprite = Special1;
				changedSprite = true;
			}
		}
		if (isBlocking) {
			sr.sprite = Block;
			changedSprite = true;
		}

		if (isFlinching) {
			flinchTimer -= Time.deltaTime;
			if (flinchTimer <= 0.0f) {
				health -= damage_global;
				residue_health_timer = 0.75f;
				previous_health = residue_health;
				isFlinching = false;
				canMove = true;
			} else {
				sr.sprite = Flinch;
				changedSprite = true;
			}
		}

		if (isCrouched) {
			isCrouched = false;
		}
			
	}

	private void GetJoystickAxis () {
		if (player == 1) {
			JoyConHorizontal = Input.GetAxis ("JoyConHorizontal_1");
			JoyConVertical = Input.GetAxis ("JoyConVertical_1");

			JoyConJoystick = new Vector2 (JoyConHorizontal, 0.0f);

			KeyHorizontal = Input.GetAxis ("Horizontal_1");

			KeyMovement = new Vector2 (KeyHorizontal, 0.0f);

		} else {
			JoyConHorizontal = Input.GetAxis ("JoyConHorizontal_2");
			JoyConVertical = Input.GetAxis ("JoyConVertical_2");

			JoyConJoystick = new Vector2 (JoyConHorizontal, 0.0f);

			KeyHorizontal = Input.GetAxis ("Horizontal_2");

			KeyMovement = new Vector2 (KeyHorizontal, 0.0f);
		}

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			canJump = true;
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "BasicAttack_1" && player == 2) {
			if (!isBlocking) {
				TakeDamage (basicAttackDamage, 0.3f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 2.0f);
				Instantiate(otherGO.GetComponent<PlayerController>().BasicHitParticles, new Vector3(transform.position.x, otherGO.transform.position.y, transform.position.z), Quaternion.identity);
			} else {
				TakeDamage (basicAttackDamage * .5f, 0.0f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 0.5f);
				Instantiate(otherGO.GetComponent<PlayerController>().BlockParticles, new Vector3(transform.position.x, otherGO.transform.position.y, transform.position.z), Quaternion.identity);
				PlaySound ("block");
			}
		} else if (coll.gameObject.tag == "BasicAttack_2" && player == 1) {
			if (!isBlocking) {
				TakeDamage (basicAttackDamage, 0.3f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 2.0f);
				Instantiate(otherGO.GetComponent<PlayerController>().BasicHitParticles, new Vector3(transform.position.x, otherGO.transform.position.y, transform.position.z), Quaternion.identity);
			} else {
				TakeDamage (basicAttackDamage * .5f, 0.0f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 0.5f);
				Instantiate(otherGO.GetComponent<PlayerController>().BlockParticles, new Vector3(transform.position.x, otherGO.transform.position.y, transform.position.z), Quaternion.identity);
				PlaySound ("block");
			}
		} else if (coll.gameObject.tag == "CrouchAttack_1" && player == 2) {
			if (!isBlocking) {
				TakeDamage (basicAttackDamage, 0.3f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 2.0f);
			} else {
				TakeDamage (basicAttackDamage * .5f, 0.0f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 0.5f);
				PlaySound ("block");
			}
		} else if (coll.gameObject.tag == "CrouchAttack_2" && player == 1) {
			if (!isBlocking) {
				TakeDamage (basicAttackDamage, 0.3f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 2.0f);
			} else {
				TakeDamage (basicAttackDamage * .5f, 0.0f);
				otherGO.GetComponent<PlayerController> ().IncreaseSpecial (basicAttackDamage * 0.5f);
				PlaySound ("block");
			}
		}
	}

	void IncreaseSpecial (float increment) {
		special = Mathf.Min (100.0f, special + increment);
		if (special == 100) {
			ultimateGlow.SetActive(true);
		}
	}

	void TakeDamage (float damage, float flinch) {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + .01f);
		damage_global = damage;
		PlaySound ("flinch");
		if (flinch > 0.0f) {
			isFlinching = true;
			flinchTimer = flinch;
			canMove = false;
			if (transform.position.x < otherGO.transform.position.x) {
				rb.velocity = new Vector2 (-1.0f, rb.velocity.y);
			} else {
				rb.velocity = new Vector2 (1.0f, rb.velocity.y);
			}
		}
	}
}
