using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferencePaintingCore : MonoBehaviour {

    //this variable lets you decide per block what color it will change to
    public Color currColor;

    //access render to apply color to
    private MeshRenderer r;

    // Use this for initialization
    void Start()
    {
        //Need to get the renderer of the object before we can make changes to it
        r = GetComponent<MeshRenderer>();
        ChangeColor();

    }

    // Update is called once per frame
    void Update()
    {
    }

    //Change the color when key is painted
    void ChangeColor()
    {
        //Need to get a color that set our material color to it
        r.material.color = currColor;
    }
}
