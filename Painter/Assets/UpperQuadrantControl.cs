using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperQuadrantControl : MonoBehaviour {
    public List<GameObject> changeList = new List<GameObject>();
    public List<GameObject> UpperQuadrant = new List<GameObject>();
    public List<GameObject> LowerQuadrant = new List<GameObject>();
    PaintingCore paint;
    // Use this for initialization
    void Start () {
		for (int i = 0; i < UpperQuadrant.Count; i++)
        {
            paint = UpperQuadrant[i].GetComponent<PaintingCore>();
            paint.CanChangeColor = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("down"))
        {
            for (int i = 0; i < UpperQuadrant.Count; i++)
            {
                paint = UpperQuadrant[i].GetComponent<PaintingCore>();
                paint.CanChangeColor = false;

                paint = LowerQuadrant[i].GetComponent<PaintingCore>();
                paint.CanChangeColor = true;
            }
        }

        if (Input.GetKeyDown("up"))
        {
            for (int i = 0; i < UpperQuadrant.Count; i++)
            {
                paint = UpperQuadrant[i].GetComponent<PaintingCore>();
                paint.CanChangeColor = true;

                paint = LowerQuadrant[i].GetComponent<PaintingCore>();
                paint.CanChangeColor = false;
            }
        }
    }
}
