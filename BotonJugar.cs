using UnityEngine;
using System.Collections;

public class BotonJugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		} 
		else if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("GameScene");
		}
	}

	void OnMouseDown() {
		Camera.main.audio.Stop ();
		audio.Play ();
		Invoke ("CargarEscena", audio.clip.length);
	}

	void CargarEscena() {
		Application.LoadLevel("GameScene");
	}
}
