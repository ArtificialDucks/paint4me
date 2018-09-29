using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Color myColor;


    private MeshRenderer r;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("[1]"))
        {
            myColor = Color.blue;
        }

        if (Input.GetKeyDown("[2]"))
        {
            myColor = Color.red;
        }

        if (Input.GetKeyDown("[3]"))
        {
            myColor = Color.yellow;
        }

        if (Input.GetKeyDown("[4]"))
        {
            myColor = Color.green;
        }
    }
}
