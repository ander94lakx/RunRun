using UnityEngine;
using System.Collections;

public class MostrarPuntuacionesFinal : MonoBehaviour {

	public TextMesh punt;
	public TextMesh puntMax;

	// Use this for initialization
	void Start () {
		punt.text = EstadoJuego.estadoJuego.puntuacionAnterior.ToString ();
		puntMax.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
