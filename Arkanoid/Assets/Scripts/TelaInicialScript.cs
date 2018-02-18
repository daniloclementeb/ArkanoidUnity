using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaInicialScript : MonoBehaviour {

	// Use this for initialization
	public Text pontos;

	void Start () {
		pontos.text = PrincipalScript.pontos.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			PrincipalScript.vidaBloco = 3;
			PrincipalScript.vida = 3;
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("GameScene");
		}
	}
}
