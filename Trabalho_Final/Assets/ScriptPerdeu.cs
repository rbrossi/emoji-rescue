using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPerdeu : MonoBehaviour {

	Gerenciador gerenciador = Gerenciador.getInstance();

	// Use this for initialization
	void Start () {
		StartCoroutine(Whatever());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Whatever()
	{
		float timeToWait = 2;
		float incrementToRemove  = 0.5f;
		while(timeToWait > 0)
		{
			yield return new WaitForSeconds(incrementToRemove );
			timeToWait -= incrementToRemove;
		}
		SceneManager.LoadScene (gerenciador.getCena());
	}
}
