using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosScript : MonoBehaviour {
	public Text pontos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pontos.text = PrincipalScript.pontos.ToString();
	}
}
