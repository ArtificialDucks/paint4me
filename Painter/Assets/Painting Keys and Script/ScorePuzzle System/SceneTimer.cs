using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTimer : MonoBehaviour {

	public float targetTime = 60.0f;
	public swapPaintings swap;
	public bool timerRunning = true;
	public Text timer;

	// Use this for initialization
	void Start () {
		
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
	}

	void timerEnded()
	{
		targetTime = 30.0f;
		swap.Next ();
	}
}
