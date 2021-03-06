﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPaintingOnOff : MonoBehaviour {
	public List<GameObject> PaintingSelections = new List<GameObject>();
	public GameObject completeScr;
	public GameObject practiceScr;
    private bool activate;
    // Use this for initialization
    void Start () {
		for (int i = 0; i < PaintingSelections.Count; i++)
        {
            PaintingSelections[i].SetActive(false);
        }
        activate = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivateReferences()
    {
        for (int i = 0; i < PaintingSelections.Count; i++)
        {
            PaintingSelections[i].SetActive(true);
        }
		completeScr.SetActive(false);
		practiceScr.SetActive(false);
        activate = true;
    }

    public void DeactivateReferences()
    {
        for (int i = 0; i < PaintingSelections.Count; i++)
        {
            PaintingSelections[i].SetActive(false);
        }
        activate = false;
    }

    public void Clicked()
    {
        if (activate == false)
        {
			ActivateReferences();
        }
        else
        {
            DeactivateReferences();
        }
        
    }
}
