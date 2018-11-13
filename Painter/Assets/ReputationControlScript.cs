using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputationControlScript : MonoBehaviour {
    public int Reputation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateReputation(int TimeSpent, int Score)
    {
        //better score and less time spent painting increase reputation more
        //Reputation += (Score/TimeSpent);
        Reputation += Score;
    }
}
