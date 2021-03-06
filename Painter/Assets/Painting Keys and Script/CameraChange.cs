﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
    //locations for camera to move between for multi quadrant paintings
    public GameObject g1, g2, g3, g4, g5, g6, g7, g8, g9;
    //need a list of the quadrant controllers
    public List<GameObject> QuadrantControllers = new List<GameObject>();
    UpperQuadrantControl QuadScript;

    //camera locations to be used with scroll wheel
    public List<GameObject> ScrollWheelLocations = new List<GameObject>();
    CameraPosition pos;
    public float speed;
    private float step;
    private Transform EndLocation;
    private int ScrollLocation;
    private float CameraSpeed;

    public GameObject WaitingClient;
    public GameObject DisappointedClient;
    public GameObject ThumbsUpClient;
    public GameObject ShrugClient;
    public GameObject WaiveClient;
    public GameObject ClientCam;
    public bool WaitReaction, DisappointedReaction, ThumbsupReaction, ShrugReaction, WaveReaction;

    //control whether mouse can scroll or not
    public bool CanZoom;

    public int CurrentPainting;
    // Use this for initialization
    void Start () {
        pos = g4.GetComponent<CameraPosition>();
        EndLocation = pos.transform;
        CurrentPainting = 0;
        QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
        ScrollLocation = 0;
        CanZoom = true;
        CameraSpeed = 10.0f;

        WaitReaction = false;
        DisappointedReaction = false;
        ThumbsupReaction = false;
        ShrugReaction = false;
        WaveReaction = false;
	}
	
	// Update is called once per frame
	void Update () {
        //mouse wheel to scroll through paint/canvas/workshop view
        if (CanZoom == true)
        {
            var d = Input.GetAxis("Mouse ScrollWheel");
            //scroll up
            if (d > 0f)
            {
                if (ScrollLocation > 0) ScrollLocation--;
                EndLocation.position = ScrollWheelLocations[ScrollLocation].transform.position;
            }
            //scroll down
            else if (d < 0f)
            {
                if (ScrollLocation <= 1) ScrollLocation++;
                EndLocation.position = ScrollWheelLocations[ScrollLocation].transform.position;
                //activate client once player zooms out
                //ActivateClient();
            }
        }
        //turn off clients once camera is reset
        //if (transform.position == ScrollWheelLocations[0].transform.position) DeactivateClient();
        step = speed * Time.deltaTime;
        if (Input.GetKeyDown("down"))
        {
            if (pos.south != null)
            {
                EndLocation = pos.south.transform;
                pos = pos.south.GetComponent<CameraPosition>();
                ActivateQuadrant(pos.QuadValue);
            }
        }

        if (Input.GetKeyDown("up"))
        {
            if (pos.north != null)
            {
                EndLocation = pos.north.transform;
                pos = pos.north.GetComponent<CameraPosition>();
                ActivateQuadrant(pos.QuadValue);
            }
        }

        if (Input.GetKeyDown("right"))
        {
            if (pos.east != null)
            {
                EndLocation = pos.east.transform;
                pos = pos.east.GetComponent<CameraPosition>();
                ActivateQuadrant(pos.QuadValue);
            }
        }

        if (Input.GetKeyDown("left"))
        {
            if (pos.west != null)
            {
                EndLocation = pos.west.transform;
                pos = pos.west.GetComponent<CameraPosition>();
                ActivateQuadrant(pos.QuadValue);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, EndLocation.position, step*CameraSpeed);
    }

    void ActivateQuadrant(int val)
    {
        if (val == 1)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq1();
        }

        else if (val == 2)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq2();
        }

        else if (val == 3)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq3();
        }

        else if (val == 4)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq4();
        }

        else if (val == 5)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq5();
        }

        else if (val == 6)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq6();
        }

        else if (val == 7)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq7();
        }

        else if (val == 8)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq8();
        }

        else if (val == 9)
        {
            QuadScript = QuadrantControllers[CurrentPainting].GetComponent<UpperQuadrantControl>();
            QuadScript.Activateq9();
        }
    }

    public void ClientWait()
    {
        WaitingClient.SetActive(true);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(true);
        StartCoroutine(WaitWait());
    }

    public void ClientThumbsUp()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(true);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(true);
        StartCoroutine(WaitThumbsUp());
    }

    public void ClientShrug()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(true);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(true);
        StartCoroutine(WaitShrug());
    }

    public void ClientDisappointed()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(true);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(true);
        StartCoroutine(WaitDisappoint());
    }

    public void ClientWaive()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(true);
        ClientCam.SetActive(true);
        StartCoroutine(WaitWaive());
    }

    void ActivateClient()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(true);
    }

    void DeactivateClient()
    {
        WaitingClient.SetActive(false);
        DisappointedClient.SetActive(false);
        ThumbsUpClient.SetActive(false);
        ShrugClient.SetActive(false);
        WaiveClient.SetActive(false);
        ClientCam.SetActive(false);
    }

    IEnumerator WaitShrug()
    {
        yield return new WaitForSeconds(3);
        DeactivateClient();
    }

    IEnumerator WaitWaive()
    {
        yield return new WaitForSeconds(5);
        DeactivateClient();
    }

    IEnumerator WaitDisappoint()
    {
        yield return new WaitForSeconds(5);
        DeactivateClient();
    }

    IEnumerator WaitThumbsUp()
    {
        yield return new WaitForSeconds(5);
        DeactivateClient();
    }

    IEnumerator WaitWait()
    {
        yield return new WaitForSeconds(5);
        DeactivateClient();
    }
}
