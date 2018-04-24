using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class share : MonoBehaviour 
{
	/* TWITTER VARIABLES*/

	//Twitter Share Link
	string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";

	//Language
	string TWEET_LANGUAGE = "en";

	//This is the text which you want to show
	string textToDisplay="Venci o jogo às " + System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

	/*END OF TWITTER VARIABLES*/

	/* FACEBOOK VARAIBLES */

	//App ID
	string AppID = "931129810293995";

	//This link is attached to this post
	string Link = "https://google.com";

	//The URL of a picture attached to this post. The Size must be atleat 200px by 200px.
	string Picture = "http://i-cdn.phonearena.com/images/article/85835-thumb/Google-Pixel-3-codenamed-Bison-to-be-powered-by-Andromeda-OS.jpg";

	//The Caption of the link appears beneath the link name
	string Caption = "Check out My New Score: ";

	//The Description of the link
	string Description = "Enjoy Fun, free games! Challenge yourself or share with friends. Fun and easy to use games.";

	/* END OF FACEBOOK VARIABLES */

	// Twitter Share Button	
	public void shareScoreOnTwitter () 
	{
		Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplay) + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
	}
	
	// Facebook Share Button
	public void shareScoreOnFacebook ()
	{
		Application.OpenURL ("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&link=" + Link + "&picture=" + Picture
		                     + "&caption=" + Caption + score.points + "&description=" + Description);
	}

	public void tirarFoto(){
		SceneManager.LoadScene (2);
	}
}
