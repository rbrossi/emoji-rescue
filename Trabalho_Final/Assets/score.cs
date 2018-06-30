using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour 
{
	Gerenciador gerenciador = Gerenciador.getInstance();

	// Use this for initialization
	void Start () {
		gerenciador.setCena (SceneManager.GetActiveScene ().buildIndex);
		StartCoroutine(Whatever());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Whatever()
	{
		float timeToWait = 4;
		float incrementToRemove  = 0.5f;
		while(timeToWait > 0)
		{
			yield return new WaitForSeconds(incrementToRemove );
			timeToWait -= incrementToRemove;
		}
		SceneManager.LoadScene (4);
	}
}

