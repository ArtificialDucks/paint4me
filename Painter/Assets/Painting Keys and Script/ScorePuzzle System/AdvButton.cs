﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvButton : MonoBehaviour {

	public swapPaintings swap;
	public Button nextButton;
	// Use this for initialization
	void Start () {
		nextButton.onClick.AddListener (OnClick);
	}
	// Update is called once per frame
	void Update () {
	}

	public void OnClick() {
		swap.Next ();
	}
}