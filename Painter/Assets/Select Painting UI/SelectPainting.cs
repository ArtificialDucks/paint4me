using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPainting : MonoBehaviour {
    public int PaintingNumber = 0;
    public int RepRequirement = 0;
    public int MoneyRequirement = 0;
    public int CurrentReputation = 0;
    public int CurrentMoney = 0;
    public GameObject PaintingSwapScript;
    public GameObject ParentScript;
    swapPaintings swap;
	SelectPaintingOnOff select;
	private bool selected;
	// Use this for initialization
	void Start () {
        swap = PaintingSwapScript.GetComponent<swapPaintings>();
        select = ParentScript.GetComponent<SelectPaintingOnOff>();
		transform.gameObject.SetActive(false);
		selected = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        if (CurrentReputation >= RepRequirement && CurrentMoney >= MoneyRequirement)
		{
			if (!selected) { 
				selected = true;
				swap.DeActivatePainting ();
				swap.ActivatePainting (PaintingNumber);
				select.DeactivateReferences ();
			}
        }
    }
}
