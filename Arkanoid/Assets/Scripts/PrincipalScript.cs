using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrincipalScript : MonoBehaviour {

	public static int vidaBloco;
	public static int vida;
	public static int pontos;
	public GameObject gameover;


	void Update () {
		if (pontos >= 9) {
			SceneManager.LoadScene ("InicioScene");
		}
		if (vida < 0) {
			Instantiate (gameover, transform.position, transform.rotation);
			SceneManager.LoadScene ("InicioScene");
		}
			
	}
}
