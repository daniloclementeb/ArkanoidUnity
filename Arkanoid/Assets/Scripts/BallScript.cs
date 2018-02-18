using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	public float velocidade;
	public SpriteRenderer vida1, vida2, vida3;
	public GameObject deathSound;
	public float forca_x, forca_y;
	// Use this for initialization
	void Start () {
		//transform.Translate (Vector2.down * velocidade * Time.deltaTime);
		GetComponent<Rigidbody2D>().AddForce(new Vector2(forca_x, forca_y));
	}
	
	// Update is called once per frame
	void Update () {
		//if (!firstTouch) {
		//	transform.Translate (Vector2.down * velocidade * Time.deltaTime);
		//}
	}
	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "fundo") {
			PrincipalScript.vida--;
			if (PrincipalScript.vida == 2) {
				Instantiate (deathSound, transform.position, transform.rotation);
				Destroy (vida3);
			}
			if (PrincipalScript.vida == 1) {
				Instantiate (deathSound, transform.position, transform.rotation);
				Destroy (vida2);
			}
			if (PrincipalScript.vida == 0) {
				Instantiate (deathSound, transform.position, transform.rotation);
				Destroy (vida1);
			}
			transform.position = new Vector2 (0.0f, 0.0f);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, -2*forca_y));
		}
	}
}
