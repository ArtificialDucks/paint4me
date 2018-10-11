using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIndicator : MonoBehaviour {

	public ColorChange color;
	private MeshRenderer r;
	// Use this for initialization
	void Start () {
		r = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		r.material.color = color.myColor;
	}
}
