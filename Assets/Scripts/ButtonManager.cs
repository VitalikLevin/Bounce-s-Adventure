using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

     public void GoMain ()
     {
		SceneManager.LoadScene(0);
     }

     public void LoadLevel (int numLvl)
     {
        SceneManager.LoadScene(numLvl);
     }

	public void ResumeLevel (GameObject obj)
	{
		obj.GetComponent<Pause> ().isPaused = false;
	}
	public void ExitLevel ()
	{
		SceneManager.LoadScene (1);
	}
	public void Restart ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
