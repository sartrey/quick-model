using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public string Title = null;

	// Use this for initialization
	void Start () {
		GameObject.Find ("Title").GetComponent<GUIText> ().text = Title;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J)) {
			Application.LoadLevel("Scene1");
		}
		if (Input.GetKey (KeyCode.K)) {
			Application.LoadLevel("Scene2");
		}
	}
}
