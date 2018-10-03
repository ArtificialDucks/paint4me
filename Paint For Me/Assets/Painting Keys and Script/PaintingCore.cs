using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is just the code that changes a cube's color when its corresponding key is pressed
public class PaintingCore : MonoBehaviour {
    //this public variable will allow anyone to enter which key the object should correspond to i.e a, b, c, etc
    public string InputKey;

    //this variable lets you decide per block what color it will change to
    public Color myColor;


    private MeshRenderer r;
    //private bool canChange;
    // Use this for initialization
    void Start () {
        //Need to get the renderer of the object before we can make changes to it
        r = GetComponent<MeshRenderer>();

        //allow the color to be changed
        //canChange = true;
	}
	
	// Update is called once per frame
	void Update () {
		
        //change color when the key is pressed
        if (Input.GetKeyDown(InputKey))
        {
            ChangeColor();
        }
	}
    
    //Change the color when key is painted
    void ChangeColor()
    {
        //Need to get a color that set our material color to it
        r.material.color = myColor;
    }
}
