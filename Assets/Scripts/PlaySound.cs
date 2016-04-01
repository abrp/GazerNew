using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	private AudioSource m_audioSouce;
	private Animator m_animator;

	private void Start(){
		m_audioSouce = GetComponent<AudioSource> ();
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


	public void Play(){
		m_audioSouce.Play ();
	}
}
