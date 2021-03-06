﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    //public so other scripts can find currently active color
    public Color myColor, Mixed1, Mixed2, TempColorR, TempColorG, TempColorB;
    private int ColorCount, ChangeCount;
    private bool ColorMix, BothColorsPicked, RedMix, BlueMix, FinishNow, YellowMix, f3Filled, f4Filled;

	public GameObject mix_strt;
	public GameObject mix_red;
	public GameObject mix_yel;
	public GameObject mix_blu;
	public GameObject mix_kp;
	//public GameObject mix_end;

	public AudioSource audiosrc;
	public AudioClip swish;
    // Use this for initialization
    void Start () {
        myColor = Color.white;
        Mixed1 = Color.white;
        Mixed2 = Color.white;
        f3Filled = false;
        f4Filled = false;
        BothColorsPicked = false;
        FinishNow = false;
        ChangeCount = 1;

		audiosrc = GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {
       // if (ColorMix == false)
        //{
           if (Input.GetKeyDown(KeyCode.F1))
           {
               myColor = new Color32(0, 0, 0, 255);
			audiosrc.PlayOneShot (swish, 1.0f);
           }

           if (Input.GetKeyDown(KeyCode.F2))
           {
			myColor = new Color32(255, 255, 255, 255);
			audiosrc.PlayOneShot (swish, 1.0f);
           }

           if (Input.GetKeyDown(KeyCode.F3))
           {
			myColor = Mixed1;
			audiosrc.PlayOneShot (swish, 1.0f);
           }

           if (Input.GetKeyDown(KeyCode.F4))
           {
			myColor = Mixed2;
			audiosrc.PlayOneShot (swish, 1.0f);
           }

           if (Input.GetKeyDown(KeyCode.F5))
           {
			myColor = new Color32(255, 0, 0, 255);
			audiosrc.PlayOneShot (swish, 1.0f);
               RedMix = true;
            if (ColorMix == false)
            {
                YellowMix = false;
                BlueMix = false;
            }
            //if (FinishNow == true)
            //   {
            //       FinishMix();
            //       
            //   }
           }

           if (Input.GetKeyDown(KeyCode.F6))
           {
			myColor = new Color32(255, 255, 0, 255);
			audiosrc.PlayOneShot (swish, 1.0f);
               YellowMix = true;
               if (ColorMix == false)
           {
                BlueMix = false;
                RedMix = false;
           }
               //if (FinishNow == true)
               //{
               //    FinishMix();
               //
               //}
           }

           if (Input.GetKeyDown(KeyCode.F7))
           {
			myColor = new Color32(0, 0, 255, 255);
			audiosrc.PlayOneShot (swish, 1.0f);
               BlueMix = true;
            if (ColorMix == false)
            {
                YellowMix = false;
                RedMix = false;
            }
            //if (FinishNow == true)
            //   {
            //       FinishMix();
            //
            //   }
           }

           if (Input.GetKeyDown(KeyCode.F8))
           {
               //brown
			myColor = new Color(0.647f, 0.165f, 0.165f, 1.0f);
			audiosrc.PlayOneShot (swish, 1.0f);
           }
        //}
        //activate color mix mode
        if (Input.GetKeyDown("[+]"))
        {
            //if (ColorMix == true)
            //{
            //    FinishMix();
			//	mix_strt.SetActive(true);
			//	mix_kp.SetActive(false);
			//	mix_end.SetActive(false);
            //    ColorMix = false;
            //}
            if (ColorMix == false)
            {
				//Debug.Log("color mix now true");
				mix_strt.SetActive(false);
				//mix_red.SetActive(true);
				//mix_yel.SetActive(true);
				//mix_blu.SetActive(true);
                ColorMix = true;
            } 
        }

        if (ColorMix == true)
        {
            if (Input.GetKeyDown("1") || Input.GetKeyDown("2") || Input.GetKeyDown("3") || Input.GetKeyDown("4") || Input.GetKeyDown("5") ||
                    Input.GetKeyDown("6") || Input.GetKeyDown("7") || Input.GetKeyDown("q") || Input.GetKeyDown("w") || Input.GetKeyDown("e")
                    || Input.GetKeyDown("r") || Input.GetKeyDown("t") || Input.GetKeyDown("y") || Input.GetKeyDown("u") || Input.GetKeyDown("a")
                    || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetKeyDown("h")
                    || Input.GetKeyDown("j") || Input.GetKeyDown("z") || Input.GetKeyDown("x") || Input.GetKeyDown("c") || Input.GetKeyDown("v")
                    || Input.GetKeyDown("b") || Input.GetKeyDown("n") || Input.GetKeyDown("m"))
            {
                FinishMix();
            }
            //mixing purple
            if (BlueMix == true && RedMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
				{
					//mix_yel.SetActive(false);
					mix_kp.SetActive(true);
					//mix_end.SetActive(true);
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorR = new Color(0.1f, 0.0f, 0.0f);
                    TempColorB = new Color(0.0f, 0.0f, 0.1f);
                }
                
                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.r < 0.490f)
                    {
                        myColor += TempColorR;
                    }
                    if (myColor.b < 1.0f)
                    {
                        myColor += TempColorB;
                    }
                }
            }
            //mixing green
            else if (BlueMix == true && YellowMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
				{
					//mix_red.SetActive(false);
					mix_kp.SetActive(true);
					//mix_end.SetActive(true);
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorG = new Color(0.0f, 0.1f, 0.0f);
                }

                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.g < 0.60f)
                    {
                        myColor += TempColorG;

                    }
                }
            }
            else if (YellowMix == true && RedMix == true)
            {
                if (BothColorsPicked = true && ChangeCount == 1)
				{
					//mix_blu.SetActive(false);
					mix_kp.SetActive(true);
					//mix_end.SetActive(true);
                    myColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                    ChangeCount = 0;
                    //Debug.Log("reset color to black");
                    TempColorR = new Color(0.1f, 0.0f, 0.0f);
                    TempColorG = new Color(0.0f, 0.1f, 0.0f);
                }

                //mixing with numpad
                if (Input.GetKeyDown("[1]") || Input.GetKeyDown("[2]") || Input.GetKeyDown("[3]") || Input.GetKeyDown("[4]") || Input.GetKeyDown("[5]") ||
                    Input.GetKeyDown("[6]") || Input.GetKeyDown("[7]") || Input.GetKeyDown("[8]") || Input.GetKeyDown("[9]"))
                {
                    if (myColor.r < 1.0f)
                    {
                        myColor += TempColorR;
                    }
                    if (myColor.g < 0.5f)
                    {
                        myColor += TempColorG;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.F7))
			{
				//mix_blu.SetActive(false);
                BlueMix = true;
                //Debug.Log("blue mix = true");
            }
            else if (Input.GetKeyDown(KeyCode.F6))
			{
				//mix_yel.SetActive(false);
                YellowMix = true;
                //Debug.Log("yellow mix = true");
            }

            else if (Input.GetKeyDown(KeyCode.F5))
            {
				//Debug.Log("red mix = true");
				//mix_red.SetActive(false);
                RedMix = true;
            }
        }
    }

    void FinishMix()
    {
        mix_strt.SetActive(true);
        mix_kp.SetActive(false);
        //mix_end.SetActive(false);
        ColorMix = false;

        if (f3Filled == false)
        {
            Mixed1 = myColor;
            f3Filled = true;
        }
        else if (f3Filled == true && f4Filled == true)
        {
            Mixed1 = myColor;
            f4Filled = false;
        }
        else
        {
            Mixed2 = myColor;
            f4Filled = true;
        }
        ReinitializeVars();
        //Debug.Log("Reset vars now");
        
    }

    void ReinitializeVars()
    {
        ColorMix = false;
        RedMix = false;
        BlueMix = false;
        YellowMix = false;
        FinishNow = false;
        ChangeCount = 1;
        //Debug.Log("reinitializing vars");
    }
}