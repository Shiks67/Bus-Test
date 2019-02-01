using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDisplay : MonoBehaviour {

	/// <summary>
	/// Change current state of the menu (active/disable)
	/// </summary>
	public void DisplayManager()
	{
		gameObject.SetActive(!gameObject.activeSelf);
	}

	/// <summary>
	/// quit the application
	/// </summary>
	public void QuitGame()
	{
		Application.Quit();
	}
}
