using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBlock : Puzzle {

	public Color matchColor;
	private MeshRenderer r;

	// Use this for initialization
	void Start () {
		r = GetComponent<MeshRenderer> ();	
	}
	
	// Update is called once per frame
	void Update () {

		//Check for matched color & update isSolved flag for ScoreController object
		if (r.material.color == matchColor) {
			isSolved = true;
		} else
			isSolved = false;
	}
}
