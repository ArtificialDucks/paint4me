using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    //public so other scripts can find currently active color
    public Color myColor;
    private int ColorCount;
    private bool ColorMix, RedMix, BlueMix, YellowMix;
    // Use this for initialization
    void Start () {
        myColor = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        if (ColorMix == false)
        {
            if (Input.GetKeyDown("[1]"))
            {
                myColor = Color.black;
            }

            if (Input.GetKeyDown("[2]"))
            {
                myColor = Color.white;
            }

            if (Input.GetKeyDown("[3]"))
            {
                myColor = Color.red;
            }

            if (Input.GetKeyDown("[4]"))
            {
                //myColor = Color.green;
                //will be orange
            }

            if (Input.GetKeyDown("[5]"))
            {
                myColor = Color.yellow;

            }

            if (Input.GetKeyDown("[6]"))
            {
                myColor = Color.green;
            }

            if (Input.GetKeyDown("[7]"))
            {
                myColor = Color.blue;
            }

            if (Input.GetKeyDown("[8]"))
            {
                myColor = new Color(0.647f, 0.165f, 0.165f, 1.0f);
            }
        }
        //activate color mix mode
        if (Input.GetKeyDown("[+]"))
        {
            if (ColorMix == false)
            {
                //Debug.Log("color mix now true");
                ColorMix = true;
            }
            //else
            //{
            //    ColorMix = false;
            //}   
        }

        if (ColorMix == true)
        {
            if (BlueMix == true && RedMix == true)
            {
                myColor = new Color32(255, 0, 255, 1);
                ReinitializeVars();
                //Debug.Log("should now be purple");
            }
            else if (BlueMix == true && YellowMix == true)
            {
                myColor = new Color32(34, 139, 34, 1);
                ReinitializeVars();
                //Debug.Log("should now be green");
            }
            else if (YellowMix == true && RedMix == true)
            {
                myColor = new Color32(255, 140, 0, 1);
                ReinitializeVars();
                //Debug.Log("should now be orange");
            }
            else if (Input.GetKeyDown("[7]"))
            {
                BlueMix = true;
                //Debug.Log("blue mix = true");
            }
            else if (Input.GetKeyDown("[5]"))
            {
                YellowMix = true;
                //Debug.Log("yellow mix = true");
            }

            else if (Input.GetKeyDown("[3]"))
            {
                //Debug.Log("red mix = true");
                RedMix = true;
            }
        }

        if (Input.GetKeyDown("[-]"))
        {
            ColorMix = false;
        }
    }

    void ReinitializeVars()
    {
        ColorMix = false;
        RedMix = false;
        BlueMix = false;
        YellowMix = false;
        //Debug.Log("reinitializing vars");
    }
}
