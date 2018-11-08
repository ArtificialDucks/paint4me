using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPainting : MonoBehaviour {
    public List<GameObject> WorkshopCanvasLocations = new List<GameObject>();
    public GameObject CurrentPainting;
    private int CurrentCanvas;
    // Use this for initialization
    void Start () {
        CurrentCanvas = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SavePainting(GameObject painting)
    {
        CurrentPainting = painting;
    }

    void DisplayPainting(GameObject painting)
    {

    }
}
