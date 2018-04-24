using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class score : MonoBehaviour 
{
	public static int points = 0;
	public Text scoreText;

	public void Start(){
		EventSystem sceneEventSystem = FindObjectOfType<EventSystem> ();
		if (sceneEventSystem == null) {
			GameObject eventSystem = new GameObject ("EventSystem");
			eventSystem.AddComponent<EventSystem> ();
			eventSystem.AddComponent<StandaloneInputModule> ();
		}
	}

	// Use this for initialization
	public void onClickScoreButton () 
	{
		points++;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
