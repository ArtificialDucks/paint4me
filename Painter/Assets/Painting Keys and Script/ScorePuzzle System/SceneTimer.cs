﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTimer : MonoBehaviour {

	public float targetTime = 30.0f;
	public swapPaintings swap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetTime -= Time.deltaTime;

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
