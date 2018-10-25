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

	public Puzzle[] puzzles; //Required points for Solved

	private int counter;
	private bool solvedCheck;
	public float targetTime = 30.0f;
	public GameObject completeScr;
	public bool timerRunning = false;
	void Start ()
	{
		completeScr.SetActive(false);
		solvedCheck = false;
		counter = 0;
		ScoreUpdate ();
	}
	// Update is called once per frame
	void Update () {
		if (timerRunning) {
			targetTime -= Time.deltaTime;
			timer.text = "Time: " + targetTime.ToString("##");
		} else
			timer.text = "";

		if (targetTime <= 0.0f)
		{
			timerEnded();
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
			solvedCheck = true;
			cashcheck = true;
		}

		ScoreUpdate ();
	}

	void ScoreUpdate () {
		//score.text = "Score: " + counter.ToString ();
		if (solvedCheck) {
			solved.text = "Judging Commissioner:\nJust what I was picturing! I must have it at once!";
			if (cashcheck) {
				cashcheck = false;
				earned.cash += counter * 100;
			}
			money.text = "$ " + earned.cash.ToString ();
			timerRunning = true;
		} else { 
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
		//targetTime = 30.0f;
		completeScr.SetActive(true);
	}
}