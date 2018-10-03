using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapPaintings : MonoBehaviour {

    public GameObject g1;
    public GameObject g2;
    // Use this for initialization
    void Start()
    {
        g2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            g1.SetActive(true);
            g2.SetActive(false);
        }

        if (Input.GetKeyDown("right"))
        {
            g1.SetActive(false);
            g2.SetActive(true);
        }
    }
}
