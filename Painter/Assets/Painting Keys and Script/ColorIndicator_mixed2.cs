﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorIndicator_mixed2 : MonoBehaviour {

	public ColorChange color;
	private Graphic r;
	// Use this for initialization
	void Start () {
		r = GetComponent<Graphic> ();
	}
	
	// Update is called once per frame
	void Update () {
		r.color = color.Mixed2;
	}
}