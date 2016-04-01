using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	[SerializeField] private Color m_hoverColor = new Color (1, 0, 0);
	[SerializeField] private Color m_defaultColor = new Color (1, 1, 1);
	private Renderer m_renderer;

	private void Start(){
		m_renderer = GetComponent<Renderer> ();
		m_renderer.material.color = m_defaultColor;
	}


	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Reticle> ()) {
			m_renderer.material.color = m_hoverColor;
		}
	}
		
	void OnTriggerExit(Collider other){
		if (other.GetComponent<Reticle> ()) {
			m_renderer.material.color = m_defaultColor;
		}
	}
}
