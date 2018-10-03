using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuzzleController : MonoBehaviour {

	//public ScoreDisplay scoreObj; //GUI Score
	public Text score;
	public Text solved;
	public Puzzle[] puzzles; //Required points for Solved

	private int counter;
	private bool solvedCheck;
	void Start ()
	{
		solvedCheck = false;
		counter = 0;
		ScoreUpdate ();
	}
	// Update is called once per frame
	void Update () {

		counter = 0;

		//Check for if a canvas block says it's "solved" increase the score
		for (int i = 0; i < puzzles.Length; i++) {

			Puzzle temp = puzzles [i];

			if (temp.isSolved == true) {
				counter += 1;
			}
		}

		//If optimal score is reached, image is "solved"
		if (counter == puzzles.Length) {
			solvedCheck = true;
		}

		ScoreUpdate ();
	}

	void ScoreUpdate () {
		score.text = "Score: " + counter.ToString ();
		if (solvedCheck) {
			solved.text = "Finished";
		} else { 
			solved.text = "Unfinished";
		}
	}
}