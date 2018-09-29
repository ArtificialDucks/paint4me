using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPaint : MonoBehaviour {
    Ray ray;
    //RaycastHit hit;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //casts a ray to the position of the mouse
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       //if (Physics.Raycast(ray, out hit))
       //{
       //   
       //    
       //}
    }
}
