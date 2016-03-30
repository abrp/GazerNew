using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public bool isGazing = false;

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Reticle> ()) {
			isGazing = true;
			GetComponent<Animator> ().SetBool ("IsOver", true);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.GetComponent<Reticle> ()) {
			GetComponent<Animator> ().SetBool ("IsOver", false);
			isGazing = false;
		}
	}


	public void Play(){
		GetComponent<AudioSource> ().Play ();
	}
}
