using UnityEngine;
using System.Collections;

public class RotatingCube : MonoBehaviour {

	private Animator m_animator;

	private void Start(){
		m_animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Reticle> ()) {
			m_animator.SetBool ("IsOver", true);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.GetComponent<Reticle> ()) {
			m_animator.SetBool ("IsOver", false);
		}
	}
}
