using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moverPelota : MonoBehaviour {
	public float velocidad;
	public Text scoreJ1;
	public Text scoreJ2;
	private int sj1 = 0;
	private int sj2 = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * velocidad;
		scoreJ1.text = "Jugador 1: " + sj1.ToString ();
		scoreJ2.text = "Jugador 2: " + sj2.ToString ();
	}

	float golpe(Vector2 posicionPelota, Vector2 posicionRaqueta, float alturaRaqueta){
		return (posicionRaqueta.y - posicionPelota.y)/alturaRaqueta;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "raquetaDerecha") {
			float y = golpe (transform.position, col.transform.position, col.collider.bounds.size.y);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1, y) * velocidad;
		} else if (col.gameObject.name == "raquetaIzquieda") {
			float y = golpe (transform.position, col.transform.position, col.collider.bounds.size.y);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (1, y) * velocidad;
		} else if (col.gameObject.name == "paredIzquierda") {
			sj2++;
			scoreJ2.text = "Jugador 2: " + sj2.ToString ();
		} else if (col.gameObject.name == "paredDerecha"){
			sj1++;
			scoreJ1.text = "Jugador 1: " + sj1.ToString ();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
