using UnityEngine;
using System.Collections;

public class BotonAcercaDe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Camera.main.audio.Stop ();
		audio.Play ();
		Invoke ("CargarEscena", audio.clip.length);
	}
	
	void CargarEscena() {
		Application.LoadLevel("MoreInfoScene");
	}
}
