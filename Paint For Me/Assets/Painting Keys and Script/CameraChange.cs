using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject g1;
    public GameObject g2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left"))
        {
            transform.position = g1.transform.position;
        }

        if (Input.GetKeyDown("right"))
        {
            transform.position = g2.transform.position;
        }
    }
}
