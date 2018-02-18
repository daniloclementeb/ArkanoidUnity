using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float velocidade;
	public float limiteInf, limiteSup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
	}

	void Mover() {
		float move_x = Input.GetAxisRaw ("Horizontal") * Time.deltaTime * velocidade;
		if (transform.position.x-0.35+move_x > limiteInf && transform.position.x+0.35+move_x < limiteSup) {
			transform.Translate (move_x, 0.0f, 0.0f);
			print (move_x);
		} 




	}
}
