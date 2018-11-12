using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuzzleController : MonoBehaviour {

	//public ScoreDisplay scoreObj; //GUI Score
	public Text score;
	public Text solved;
	public Text timer;
	public Text money;
	public Money earned;
	private bool cashcheck = false;
	private bool unsolved = true;
	private bool complete = false;

	public Puzzle[] puzzles; //Required points for Solved

	private int counter;
	private bool solvedCheck;
	public float targetTime = 0.1f;
	public GameObject completeScr;
	public GameObject soldSticker;
	public bool timerRunning = false;

	public AudioSource audiosrc;
	public AudioClip tone;

	void Start ()
	{
		soldSticker.SetActive (false);
		completeScr.SetActive(false);

		cashcheck = true;
		solvedCheck = false;
		counter = 0;
		audiosrc = GetComponent<AudioSource> ();
		ScoreUpdate ();
		timerRunning = true;
	}
	// Update is called once per frame
	void Update () {
		if (timerRunning && solvedCheck) {
			targetTime -= Time.deltaTime;
			timer.text = "Time: " + targetTime.ToString ("##");
		} else if (timerRunning && !solvedCheck) {
			targetTime += Time.deltaTime;
			timer.text = "Time: " + targetTime.ToString ("##");
		}
		else
			timer.text = "";

		if (targetTime <= 0.0f)
		{
			timer.text = "";
			if (solvedCheck) {
				timerRunning = false;
				timerEnded ();
			}
		}
		counter = 0;

		//Check for if a canvas block says it's "solved" increase the score
		for (int i = 0; i < puzzles.Length; i++) {

			Puzzle temp = puzzles [i];

			if (temp.isSolved == true) {
				counter += 1;
			}
		}

		//If optimal score is reached, image is "solved"
		if (counter == puzzles.Length && unsolved) {
			unsolved = false;
		}

		ScoreUpdate ();
	}

	void ScoreUpdate () {
		//score.text = "Score: " + counter.ToString ();
		if (solvedCheck && !unsolved) {
			timerRunning = false;
			solved.text = "Judging Commissioner:\nJust what I was picturing! I must have it at once!";
			soldSticker.SetActive (true);
			if (cashcheck) {
				cashcheck = false;
				earned.cash += counter * 100;
				targetTime = 10.0f;
			}
			money.text = "$ " + earned.cash.ToString ();
			timerRunning = true;
		} else if (solvedCheck && unsolved) {
			timerRunning = false;
			solved.text = "Judging Commissioner:\nHmm... it's not quite what I was hoping for, but it'll do.";
			soldSticker.SetActive (true);
			if (cashcheck) {
				cashcheck = false;
				earned.cash += counter * 100;
				targetTime = 10.0f;
			}
			money.text = "$ " + earned.cash.ToString ();
			timerRunning = true;
		}
		else { 
			if (counter == 0) solved.text = "Judging Commissioner:\nI look forward to your finished work.";
			else if (counter == 1) solved.text = "Judging Commissioner:\nIt's coming along I see.";
			else if (counter == 2) solved.text = "Judging Commissioner:\nReally shaping up now.";
			else if (counter == 3) solved.text = "Judging Commissioner:\nYou really have some talent!";
			else if (counter == 4) solved.text = "Judging Commissioner:\nThis is turning into a masterpiece!";
			else if (counter == 5) solved.text = "Judging Commissioner:\nIt's so beautiful... *sniff*";
		}
	}
	void timerEnded()
	{
		if (solvedCheck && !complete) {
			complete = true;
			audiosrc.PlayOneShot (tone, 1.0f);
			completeScr.SetActive (true);
			timerRunning = false;
		}
	}
	public void PlayerSubmit()
	{
		solvedCheck = true;
	}
}