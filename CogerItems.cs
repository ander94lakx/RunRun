using UnityEngine;
using System.Collections;

public class CogerItems : MonoBehaviour {

	public int puntuacion = 0; // Cuenta el numero de items que ha cogido
	public TextMesh marcador;
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");
		ActualizarMarcador ();
	}

	void PersonajeHaMuerto(Notification notificacion){
		EstadoJuego.estadoJuego.puntuacionAnterior = puntuacion;
		if (puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima) {
			EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
		}
		EstadoJuego.estadoJuego.Guardar();
	}
	// Update is called once per frame
	void Update () {
		
	}

	void ActualizarMarcador(){
		marcador.text = puntuacion.ToString ();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "ItemColeccionable") {
			audio.Play();
			Destroy(other.gameObject);
			puntuacion += 5;
			ActualizarMarcador();
		}
	}
}
