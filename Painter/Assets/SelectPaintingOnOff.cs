using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPaintingOnOff : MonoBehaviour {
    public List<GameObject> PaintingSelections = new List<GameObject>();
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

    void OnMouseDown()
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
