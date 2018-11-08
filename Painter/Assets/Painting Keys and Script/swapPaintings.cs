using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapPaintings : MonoBehaviour
{

    //list of different paintings we have for activating and deactivating
    public List<GameObject> gList = new List<GameObject>();
    int currObj;
    //list of quadrants to activate or deactivate
    public List<GameObject> QuadrantControllers = new List<GameObject>();
    UpperQuadrantControl QuadScript;
    //need camera script to warn after painting change
    public GameObject cam;
    public GameObject completeScr;
    public GameObject soldSticker;
    CameraChange CamChange;

    // Use this for initialization
    void Start()
    {
        //need to know which painting we're currently on
        currObj = 0;

        //deactivate all but the first painting
        for (int i = 1; i < gList.Count; i++)
        {
            gList[i].SetActive(false);
        }

        cam = GameObject.Find("Main Camera");
        CamChange = cam.GetComponent<CameraChange>();
    }

    // Update is called once per frame
    void Update()
    {
        //move to next painting on left click - for debugging
        // if (Input.GetMouseButtonDown(0) && currObj < gList.Count - 1)
        // {
        //	Next ();
        // }
        // //move to previous painting on right click
        // if (Input.GetMouseButtonDown(1) && currObj > 0)
        // {
        //	Previous ();
        // }
    }

    public void ActivatePainting(int num)
    {
        currObj = num;
        gList[currObj].SetActive(true);
        CamChange.CurrentPainting = num;
    }

    public void DeActivatePainting()
    {
        gList[currObj].SetActive(false);
    }

    public void SetCurrentNumberPainting(int num)
    {
        currObj = num;
    }
    public void Next()
    {

        //old code for debugging
        //if (currObj < gList.Count - 1) {
        //	gList [currObj].SetActive (false);
        //	gList [currObj + 1].SetActive (true);
        //	completeScr.SetActive(false);
        //	soldSticker.SetActive(false);
        //	currObj++;
        //	CamChange.CurrentPainting++;
        //}
    }

    public void Previous()
    {
        //this should only be used for debugging
        if (currObj > 0)
        {
            gList[currObj].SetActive(false);
            gList[currObj - 1].SetActive(true);
            completeScr.SetActive(false);
            soldSticker.SetActive(false);
            currObj--;
            CamChange.CurrentPainting--;
        }
    }
}