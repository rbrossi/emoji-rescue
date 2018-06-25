using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

	public Rigidbody projetil;
	public float hSpeed, vSpeed;
	public float fireRate;
	private float timer;

	// Use this for initialization
	void Start () {
		Rigidbody tempProjetil = Instantiate (projetil, transform.position, Quaternion.Euler(0,90,90));
		tempProjetil.velocity = new Vector3 (hSpeed, 0, vSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody tempProjetil = Instantiate (projetil, transform.position, Quaternion.Euler(0,90,90));
		tempProjetil.velocity = new Vector3 (hSpeed, 0, vSpeed);
	}
}
