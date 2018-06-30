using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FuryGuy : MonoBehaviour {

	public Rigidbody projetil;
	Random r = new Random();
	Gerenciador gerenciador = Gerenciador.getInstance();
	public AudioClip acertou;
	public Text mostraVidas;
	int velocidade;

	// Use this for initialization

	void Start()
	{
		mostraVidas.text = "" + Gerenciador.getInstance().getVidas();
		InvokeRepeating("atualizar", 0.0f, 1.0f);
		this.velocidade = 3;
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

	private void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Projetil1")) {
			gerenciador.setVidas(gerenciador.getVidas()-1);
			mostraVidas.text = "" + gerenciador.getVidas();
			GetComponent<AudioSource> ().clip = acertou;
			GetComponent<AudioSource> ().Play ();
		}
		if (gerenciador.getVidas () == 0) {
			velocidade = 0;
			if (!gerenciador.isZerou ()) {
				gerenciador.setZerou (true);
				SceneManager.LoadScene (6);
			} else {
				SceneManager.LoadScene (4);
			}
		} else if (gerenciador.getVidas () == 4) {
			velocidade = 4;
		} else if (gerenciador.getVidas () == 2) {
			velocidade = 5;
		}
	}



	// Update is called once per frame
	void Update () {
		
	}
}
