using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bola : MonoBehaviour {

	Rigidbody rb;
	public float speed;
	public Text text;

	// Use this for initialization
	void Start () {
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
			text.text = "Game Over";
			speed = 0;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		if (other.CompareTag ("WinTrigger")) {
			text.text = "You win";
			speed = 0;
			SceneManager.LoadScene (2);
		}
	}

	void ReloadScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

}
