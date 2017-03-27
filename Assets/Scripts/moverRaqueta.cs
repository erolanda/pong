using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverRaqueta : MonoBehaviour {
	public float velocidad;
	public string eje;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate(){
		float y = Input.GetAxis (eje);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, y) * velocidad;
	}
}
