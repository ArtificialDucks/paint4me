using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    //public so other scripts can find currently active color
    public Color myColor, Mixed1, Mixed2, TempColorR, TempColorG, TempColorB;
    private int ColorCount, ChangeCount;
    private bool ColorMix, BothColorsPicked, RedMix, BlueMix, YellowMix, f3Filled, f4Filled;
    // Use this for initialization
    void Start () {
        myColor = Color.white;
        Mixed1 = Color.white;
        Mixed2 = Color.white;
        f3Filled = false;
        f4Filled = false;
        BothColorsPicked = false;
        ChangeCount = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (ColorMix == false)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                myColor = new Color32(0, 0, 0, 1);
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                myColor = new Color32(255, 255, 255, 1);
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                myColor = Mixed1;
            }

            if (Input.GetKeyDown(KeyCode.F4))
            {
                myColor = Mixed2;
            }

            if (Input.GetKeyDown(KeyCode.F5))
            {
                myColor = new Color32(255, 0, 0, 1);
            }

            if (Input.GetKeyDown(KeyCode.F6))
            {
                myColor = new Color32(255, 255, 0, 1);
            }

            if (Input.GetKeyDown(KeyCode.F7))
            {
                myColor = new Color32(0, 0, 255, 1);
            }

            if (Input.GetKeyDown(KeyCode.F8))
            {
                //brown
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
        }

        if (ColorMix == true)
        {
            //mixing purple
            if (BlueMix == true && RedMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
                {
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorR = new Color(0.100f, 0.0f, 0.0f, 1.0f);
                    TempColorB = new Color(0.0f, 0.0f, 0.100f, 1.0f);
                }
                
                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.r < 0.490f)
                    {
                        myColor += TempColorR;
                        //if (myColor.r > 0.490f)
                        //{
                        //    myColor.r = 0.490f;
                        //}
                    }
                    if (myColor.b < 1.0f)
                    {
                        myColor += TempColorB;
                       //if (myColor.b > 1.0f)
                       //{
                       //    myColor.b = 1.0f;
                       //}
                    }
                }
                //myColor = new Color32(255, 0, 255, 1);
                //put color into the first used slot between f3/f4
                if (f3Filled == false)
                {
                    Mixed1 = myColor;
                    f3Filled = true;
                }
                else if (f3Filled == true && f4Filled == true)
                {
                    Mixed1 = myColor;
                }
                else
                {
                    Mixed2 = myColor;
                    f4Filled = true;
                }
                //ReinitializeVars();
                //Debug.Log("should now be purple");
                //Debug.Log(myColor);
            }
            //mixing green
            else if (BlueMix == true && YellowMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
                {
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorG = new Color(0.0f, 0.100f, 0.0f, 1.0f);
                }

                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.g < 0.60f)
                    {
                        myColor += TempColorG;
                        //if (myColor.r > 0.60f)
                        //{
                        //    myColor.r = 0.60f;
                        //}
                    }
                }
                //myColor = new Color32(255, 0, 255, 1);
                //put color into the first used slot between f3/f4
                if (f3Filled == false)
                {
                    Mixed1 = myColor;
                    f3Filled = true;
                }
                else if (f3Filled == true && f4Filled == true)
                {
                    Mixed1 = myColor;
                }
                else
                {
                    Mixed2 = myColor;
                    f4Filled = true;
                }
                //ReinitializeVars();
                //Debug.Log("should now be purple");
                //Debug.Log(myColor);
            }
            else if (YellowMix == true && RedMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
                {
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorR = new Color(0.100f, 0.0f, 0.0f, 1.0f);
                    TempColorG = new Color(0.0f, 0.100f, 0.0f, 1.0f);
                }

                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.r < 1.0f)
                    {
                        myColor += TempColorR;
                        //if (myColor.r > 1.0f)
                        //{
                        //    myColor.r = 1.0f;
                        //}
                    }
                    if (myColor.g < 0.5f)
                    {
                        myColor += TempColorG;
                        //if (myColor.g > 0.5f)
                        //{
                        //    myColor.g = 0.5f;
                        //}
                    }
                }
                //myColor = new Color32(255, 0, 255, 1);
                //put color into the first used slot between f3/f4
                if (f3Filled == false)
                {
                    Mixed1 = myColor;
                    f3Filled = true;
                }
                else if (f3Filled == true && f4Filled == true)
                {
                    Mixed1 = myColor;
                }
                else
                {
                    Mixed2 = myColor;
                    f4Filled = true;
                }
                //ReinitializeVars();
                //Debug.Log("should now be purple");
                //Debug.Log(myColor);
            }
            else if (Input.GetKeyDown(KeyCode.F7))
            {
                BlueMix = true;
                //Debug.Log("blue mix = true");
            }
            else if (Input.GetKeyDown(KeyCode.F6))
            {
                YellowMix = true;
                //Debug.Log("yellow mix = true");
            }

            else if (Input.GetKeyDown(KeyCode.F5))
            {
                //Debug.Log("red mix = true");
                RedMix = true;
            }
        }

        if (Input.GetKeyDown("[0]"))
        {
            //ReinitializeVars();
            ReinitializeVars();
            //Debug.Log("Reset vars now");
        }
    }

    void ReinitializeVars()
    {
        ColorMix = false;
        RedMix = false;
        BlueMix = false;
        YellowMix = false;
        ChangeCount = 1;
        //Debug.Log("reinitializing vars");
    }
}
