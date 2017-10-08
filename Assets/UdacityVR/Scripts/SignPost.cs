using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	private int coinCount;
	private string uiTextFormat = "You completed the maze!\n Coins Collected: {0}/6\n Click me to restart!";

	void Start()
	{
		coinCount = 0;
	}

	public void ResetScene() 
	{
		// "UdacityVR/Scenes/A Maze"
		SceneManager.LoadScene ("A Maze");
	}

	public void UpdateCount()
	{
		this.coinCount++;
		Text signText = GetComponent<Text> ();
		signText.text = string.Format (uiTextFormat, this.coinCount);
	}
}