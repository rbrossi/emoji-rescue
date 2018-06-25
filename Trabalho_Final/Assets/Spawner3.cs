using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour {
	public Rigidbody projetil;
	public float hSpeed, vSpeed;
	Gerenciador gerenciador = Gerenciador.getInstance();
	private float timer;
	private bool haProjetil;
	private int conta = 0;

	// Use this for initialization
	void Start () {		

	}

	// Update is called once per frame
	void Update () {
		if(!gerenciador.isDisparar()){
			return;
		}
		else if (gerenciador.isLiberadoBotao2 ()) {
			timer += Time.deltaTime;
			if (timer >= 0) {
				Rigidbody tempProjetil = Instantiate (projetil, gerenciador.getPosicaoBola(), Quaternion.Euler (90, 00, 90));
				tempProjetil.velocity = new Vector3 (hSpeed, 0, vSpeed);
				conta++;
				//Debug.Log (conta);
				timer = 0;
			} 
			if (conta == 1) {
				timer = 0;
				conta = 0;
				gerenciador.setLiberadoBotao1 (true);
				gerenciador.setLiberadoBotao2 (false);
				gerenciador.setDisparar (false);
				gerenciador.setCarregado (false);
			}
			Debug.Log (gerenciador.getPosicaoBola ());
		}
	}
}
