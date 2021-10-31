using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestWall : MonoBehaviour 
{
	public Animator stoneAnim;
	public GameObject stoneCollider;
	private void Start ()
	{
		stoneAnim = GetComponent<Animator> ();
	}
	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag != "Player" && other.GetComponent<Pickup>().id == 2)
		{
			Destroy (other.gameObject);
			stoneAnim.SetTrigger ("isTriggered");
			stoneCollider.SetActive (false);
		}
	}
}
