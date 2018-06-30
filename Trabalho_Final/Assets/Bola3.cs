using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bola3 : MonoBehaviour {

	Rigidbody rb;
	public float speed;
	public Text text;
	Gerenciador gerenciador = Gerenciador.getInstance();

	// Use this for initialization
	void Start () {
		gerenciador.setCena (SceneManager.GetActiveScene ().buildIndex);
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	private void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	private void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Projetil")) {
			speed = 0;
			SceneManager.LoadScene(5);
		}
		if (other.CompareTag ("WinTrigger")) {
			speed = 0;
			if (gerenciador.isZerou ()) {
				SceneManager.LoadScene (4);
			} else {
				SceneManager.LoadScene (1);
			}
		}
	}

	void ReloadScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

}
