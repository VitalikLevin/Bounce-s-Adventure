using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public void BonusGame ()
	{
		SceneManager.LoadScene (17);
	}

	public void Network ()
	{
		Application.OpenURL ("https://vk.com/vita2009"); //Fool's day https://clck.ru/9TFat
	}

	public void ShowPanel (GameObject obj) 
	{
		obj.SetActive (true);
	}

	public void HidePanel (GameObject obj)
	{
		obj.SetActive (false);
	}

	public void NewGame()
	{
		SceneManager.LoadScene (1);
	}

	public void Exit ()
	{
		Application.Quit ();
	}
}
