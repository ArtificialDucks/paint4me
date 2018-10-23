using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBlock : Puzzle {

	public Color inputColor;
	private Color matchColor;
	private MeshRenderer r;
	private int count;
	// Use this for initialization
	void Start () {
		r = GetComponent<MeshRenderer> ();
		matchColor = new Color32(inputColor[0], inputColor[1], inputColor[2], inputColor[3]);
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Color " + r.material.color [0].ToString () + r.material.color [1].ToString () + r.material.color [2].ToString ());
		Debug.Log ("Match " + matchColor [0].ToString () + matchColor [1].ToString () + matchColor [2].ToString ());
		//Check for matched color & update isSolved flag for ScoreController object
		if (r.material.color[0] >= (matchColor[0] - 0.25) && r.material.color[0] <= (matchColor[0] + 0.25)) count += 1;
		if (r.material.color[1] >= (matchColor[1] - 0.25) && r.material.color[1] <= (matchColor[1] + 0.25)) count += 1;
		if (r.material.color[2] >= (matchColor[2] - 0.25) && r.material.color[2] <= (matchColor[2] + 0.25)) count += 1;

		if (count == 3) isSolved = true;
		else
			isSolved = false;
	}
}