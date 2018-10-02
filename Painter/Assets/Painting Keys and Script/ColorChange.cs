using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    //public so other scripts can find currently active color
    public Color myColor;

    // Use this for initialization
    void Start () {
        myColor = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("[1]"))
        {
            myColor = Color.white;
        }

        if (Input.GetKeyDown("[2]"))
        {
            myColor = Color.black;
        }

        if (Input.GetKeyDown("[3]"))
        {
            myColor = Color.yellow;
        }

        if (Input.GetKeyDown("[4]"))
        {
            myColor = Color.green;
        }

        if (Input.GetKeyDown("[5]"))
        {
            myColor = Color.blue;
        }

        if (Input.GetKeyDown("[6]"))
        {
            myColor = Color.red;
        }

        if (Input.GetKeyDown("[7]"))
        {
            myColor = Color.gray;
        }

        if (Input.GetKeyDown("[7]"))
        {
            myColor = new Color(0.647f, 0.165f, 0.165f);
        }
        
    }
}
