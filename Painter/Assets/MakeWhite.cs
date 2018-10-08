using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWhite : MonoBehaviour {

    private MeshRenderer r;

    // Use this for initialization
    void Start () {
        r = GetComponent<MeshRenderer>();
        r.material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
