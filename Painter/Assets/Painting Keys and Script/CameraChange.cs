using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
    //locations for camera to move between for multi quadrant paintings
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;

    public bool moveUpDown;
    public bool moveLeftRight;

	// Use this for initialization
	void Start () {
        moveUpDown = true;
        moveLeftRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("down"))
        {
            transform.position = g1.transform.position;
        }

        if (Input.GetKeyDown("up") && moveUpDown == true)
        {
            transform.position = g2.transform.position;
        }

        if (Input.GetKeyDown("right"))
        {
            transform.position = g1.transform.position;
        }

        if (Input.GetKeyDown("left") && moveLeftRight == true)
        {
            transform.position = g3.transform.position;
        }
    }
}
