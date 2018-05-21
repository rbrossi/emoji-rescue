using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuryGuy : MonoBehaviour {

	public Rigidbody projetil;
	int velocidade = 5;
	Random r = new Random();

	// Use this for initialization

	void Start()
	{
		InvokeRepeating("atualizar", 0.0f, 1.0f);
	}

	void atualizar()
	{
		int i = Random.Range(0,2);
		if (projetil.position.z <= -4) {
			projetil.velocity = new Vector3 (0, 0, velocidade);
		} else if (projetil.position.z >= 4) {
			projetil.velocity = new Vector3 (0, 0, -velocidade);
		} else {
			if (i == 0) {
				projetil.velocity = new Vector3 (0, 0, -velocidade);
			} else {
				projetil.velocity = new Vector3 (0, 0, velocidade);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
