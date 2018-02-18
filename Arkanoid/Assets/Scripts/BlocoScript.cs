using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoScript : MonoBehaviour {
	public Text vida;
	private int vidaAtual;
	public GameObject hitSound;

	void Start () {
		vidaAtual = int.Parse(PrincipalScript.vidaBloco.ToString());
		vida.text = PrincipalScript.vidaBloco.ToString();
	}

	void Update () {
		// Atualiza o placar

	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "ball") {
			Instantiate (hitSound, transform.position, transform.rotation);
			vidaAtual--;
			vida.text = vidaAtual.ToString();
			PrincipalScript.pontos++;
		}
		if (vidaAtual == 0) {
			Destroy (gameObject);
		}
	}
}
