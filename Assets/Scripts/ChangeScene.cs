using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public string nextScene;
	void OnTriggerStay(){
		if (Input.GetMouseButton (0)) {
			SceneManager.LoadScene (nextScene);
		}
	}
}
