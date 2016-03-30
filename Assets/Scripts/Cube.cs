using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	public Color hoverColor = new Color (1, 0, 0);
	public Color defaultColor = new Color (1, 1, 1);

	public bool isGazing = false;

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Reticle> ()) {
			GetComponent<Renderer> ().material.color = hoverColor;
			isGazing = true;
		}
	}
		
	void OnTriggerExit(Collider other){
		if (other.GetComponent<Reticle> ()) {
			GetComponent<Renderer> ().material.color = defaultColor;
			isGazing = false;
		}
	}
}
