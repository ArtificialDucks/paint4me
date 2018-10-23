using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBlock : Puzzle {

	public Color inputColor;
	private Color matchColor;
	private MeshRenderer r;
	private bool chk_r = false;
    private bool chk_g = false;
    private bool chk_b = false;
    // Use this for initialization
    void Start () {
		r = GetComponent<MeshRenderer> ();
		matchColor = inputColor;
	}
	
	// Update is called once per frame
	void Update () {
		//Check for matched color & update isSolved flag for ScoreController object
		if (r.material.color [0] >= (matchColor [0] - 0.25) && r.material.color [0] <= (matchColor [0] + 0.25)) chk_r = true;
		if (r.material.color [1] >= (matchColor [1] - 0.25) && r.material.color [1] <= (matchColor [1] + 0.25)) chk_g = true;
		if (r.material.color [2] >= (matchColor [2] - 0.25) && r.material.color [2] <= (matchColor [2] + 0.25)) chk_b = true;

		if (chk_r && chk_g && chk_b) isSolved = true;
		else
			isSolved = false;
	}
}