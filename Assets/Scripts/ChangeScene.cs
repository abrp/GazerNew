using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	[SerializeField] private string m_nextScene;

	void OnTriggerStay(){
		if (Input.GetMouseButton (0)) {
			SceneManager.LoadScene (m_nextScene);
		}
	}
}
