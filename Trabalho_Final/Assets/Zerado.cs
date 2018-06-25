using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zerado : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void carrega0(){
		SceneManager.LoadScene (0);
	}

	public void carrega1(){
		SceneManager.LoadScene (1);
	}

	public void carrega2(){
		SceneManager.LoadScene (2);
	}

	public void carrega3(){
		SceneManager.LoadScene (3);
	}
}
