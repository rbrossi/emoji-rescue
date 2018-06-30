#pragma strict

import UnityEngine.SceneManagement;

var timer : float = 60.0;


function Update () {

		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			timer = 0;
			SceneManager.LoadScene(5);

		}

}
function OnGUI()
{
		GUI.skin.box.fontSize = 50;
		GUI.Box(new Rect(10,10,100,70), "" + timer.ToString("0"));
}
