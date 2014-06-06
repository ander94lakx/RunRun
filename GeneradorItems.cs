using UnityEngine;
using System.Collections;

public class GeneradorItem : MonoBehaviour {

	public GameObject[] obj;

	public float tiempoMin = 1f;
	public float tiempoMax = 2f;
	
	private bool fin = false;
	private bool empezado = false;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");
	}

	void PersonajeEmpiezaACorrer(Notification notificacion){
		Generar ();
	}

	void PersonajeHaMuerto(){
		fin = true;
	}

	// Update is called once per frame
	void Update () {

	}

	void Generar(){
		if(!fin){
			if(!empezado){
				Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
				empezado = true;
			}
			else {
				Instantiate (obj [Random.Range (0, obj.Length)], 
		     		       	 transform.position, // new Vector3 (transform.position.x, transform.position.y, transform.position.z), 
			            	 Quaternion.identity);
				Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
			}
		}
	}
}
