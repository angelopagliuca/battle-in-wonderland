using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager S = null;

	public GameObject TitleMusic;
	private AudioSource TitleMusicSound;

	public GameObject BackgroundMusic;
	private AudioSource BackgroundMusicSound;

	// Alice

    public GameObject AliceBlock;
    private AudioSource AliceBlockSound;

	public GameObject AliceJump;
	private AudioSource AliceJumpSound;

	public GameObject AliceAttack;
	private AudioSource AliceAttackSound;

	public GameObject AliceFlinch;
	private AudioSource AliceFlinchSound;

	public GameObject AliceAbility;
	private AudioSource AliceAbilitySound;

	public GameObject AliceSpecial;
	private AudioSource AliceSpecialSound;

	public GameObject AliceQuote;
	private AudioSource AliceQuoteSound;

	// Beast

	public GameObject BeastBlock;
	private AudioSource BeastBlockSound;

	public GameObject BeastJump;
	private AudioSource BeastJumpSound;

	public GameObject BeastAttack;
	private AudioSource BeastAttackSound;

	public GameObject BeastFlinch;
	private AudioSource BeastFlinchSound;

	public GameObject BeastAbility;
	private AudioSource BeastAbilitySound;

	public GameObject BeastSpecial;
	private AudioSource BeastSpecialSound;

	public GameObject  BeastQuote;
	private AudioSource BeastQuoteSound;

	// Queen

	public GameObject QueenBlock;
	private AudioSource QueenBlockSound;

	public GameObject QueenJump;
	private AudioSource QueenJumpSound;

	public GameObject QueenAttack;
	private AudioSource QueenAttackSound;

	public GameObject QueenFlinch;
	private AudioSource QueenFlinchSound;

	public GameObject QueenAbility;
	private AudioSource QueenAbilitySound;

	public GameObject QueenSpecial;
	private AudioSource QueenSpecialSound;

	public GameObject  QueenQuote;
	private AudioSource QueenQuoteSound;

	public GameObject  Click;
	private AudioSource ClickSound;

	public GameObject  Selected;
	private AudioSource SelectedSound;

	void Awake () {
		if (S == null) {
			S = this;
		} else if (S != this) {
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);

		TitleMusicSound = TitleMusic.GetComponent<AudioSource>();
		BackgroundMusicSound = BackgroundMusic.GetComponent<AudioSource>();

		AliceJumpSound = AliceJump.GetComponent<AudioSource>();
		AliceBlockSound = AliceBlock.GetComponent<AudioSource>();
		AliceFlinchSound = AliceFlinch.GetComponent<AudioSource>();
		AliceAttackSound = AliceAttack.GetComponent<AudioSource>();
		AliceAbilitySound = AliceAbility.GetComponent<AudioSource>();
		AliceSpecialSound = AliceSpecial.GetComponent<AudioSource>();
		AliceQuoteSound = AliceQuote.GetComponent<AudioSource>();

		BeastJumpSound = BeastJump.GetComponent<AudioSource>();
		BeastBlockSound = BeastBlock.GetComponent<AudioSource>();
		BeastFlinchSound = BeastFlinch.GetComponent<AudioSource>();
		BeastAttackSound = BeastAttack.GetComponent<AudioSource>();
		BeastAbilitySound = BeastAbility.GetComponent<AudioSource>();
		BeastSpecialSound = BeastSpecial.GetComponent<AudioSource>();
		BeastQuoteSound = BeastQuote.GetComponent<AudioSource>();

		QueenJumpSound = QueenJump.GetComponent<AudioSource>();
		QueenBlockSound = QueenBlock.GetComponent<AudioSource>();
		QueenFlinchSound = QueenFlinch.GetComponent<AudioSource>();
		QueenAttackSound = QueenAttack.GetComponent<AudioSource>();
		QueenAbilitySound = QueenAbility.GetComponent<AudioSource>();
		QueenSpecialSound = QueenSpecial.GetComponent<AudioSource>();
		QueenQuoteSound = QueenQuote.GetComponent<AudioSource>();

		ClickSound = Click.GetComponent<AudioSource>();
		SelectedSound = Selected.GetComponent<AudioSource>();
	}

	public void PlayTitleMusic()
	{
		TitleMusicSound.Play();
	}

	public void PlayBackgroundMusic()
	{
		BackgroundMusicSound.Play();
	}

	public void StopTitleMusic()
	{
		TitleMusicSound.Stop();
	}

	public void StopBackgroundMusic()
	{
		BackgroundMusicSound.Stop();
	}

	// Alice

    public void PlayAliceJumpSound()
    {
        AliceJumpSound.Play();
    }

	public void PlayAliceBlockSound()
	{
		AliceBlockSound.Play();
	}

	public void PlayAliceFlinchSound()
	{
		AliceFlinchSound.Play();
	}

	public void PlayAliceAttackSound()
	{
		AliceAttackSound.Play();
	}

	public void PlayAliceAbilitySound()
	{
		AliceAbilitySound.Play();
	}

	public void PlayAliceSpecialSound()
	{
		AliceSpecialSound.Play();
	}

	public void PlayAliceQuoteSound()
	{
		AliceQuoteSound.Play();
	}

	// Beast

	public void PlayBeastJumpSound()
	{
		BeastJumpSound.Play();
	}

	public void PlayBeastBlockSound()
	{
		BeastBlockSound.Play();
	}

	public void PlayBeastFlinchSound()
	{
		BeastFlinchSound.Play();
	}

	public void PlayBeastAttackSound()
	{
		BeastAttackSound.Play();
	}

	public void PlayBeastAbilitySound()
	{
		BeastAbilitySound.Play();
	}

	public void PlayBeastSpecialSound()
	{
		BeastSpecialSound.Play();
	}

	public void PlayBeastQuoteSound()
	{
		BeastQuoteSound.Play();
	}

	// Queen

	public void PlayQueenJumpSound()
	{
		QueenJumpSound.Play();
	}

	public void PlayQueenBlockSound()
	{
		QueenBlockSound.Play();
	}

	public void PlayQueenFlinchSound()
	{
		QueenFlinchSound.Play();
	}

	public void PlayQueenAttackSound()
	{
		QueenAttackSound.Play();
	}

	public void PlayQueenAbilitySound()
	{
		QueenAbilitySound.Play();
	}

	public void PlayQueenSpecialSound()
	{
		QueenSpecialSound.Play();
	}

	public void PlayQueenQuoteSound()
	{
		QueenQuoteSound.Play();
	}

	public void PlayClickSound()
	{
		ClickSound.Play();
	}

	public void PlayLockSound()
	{
		SelectedSound.Play();
	}
}
