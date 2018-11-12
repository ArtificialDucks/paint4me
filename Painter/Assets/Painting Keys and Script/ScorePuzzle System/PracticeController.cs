using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeController : MonoBehaviour {
	private bool complete = false;
	public GameObject completeScr;
	public AudioSource audiosrc;
	public AudioClip tone;

	void Start ()
	{
		completeScr.SetActive(false);
		audiosrc = GetComponent<AudioSource> ();
	}
	public void Clicked() {
		if (!complete) {
			complete = true;
			audiosrc.PlayOneShot (tone, 1.0f);
			completeScr.SetActive (true);
		}
	}
}
