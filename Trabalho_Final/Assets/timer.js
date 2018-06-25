#pragma strict

import UnityEngine.SceneManagement;

var timer : float = 60.0;

function Update () {

		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			timer = 0;
			SceneManager.LoadScene("Labirinto2");
		}

}
function OnGUI()
{
		GUI.Box(new Rect(10,10,50,20), "" + timer.ToString("0"));
}
