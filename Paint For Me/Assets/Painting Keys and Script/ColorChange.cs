using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Color myColor;


    private MeshRenderer r;

    // Use this for initialization
    void Start () {
        r = GetComponent<MeshRenderer>();
        r.material.color = myColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
