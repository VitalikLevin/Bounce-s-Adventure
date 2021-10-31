using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour 
{
	public bool[] isFull;
	public GameObject[] slots;
	public GameObject InveNtory;
	public bool inventoryOn;
	private void Start ()
	{
		inventoryOn = false;
	}
	public void Chest ()
	{
		if (inventoryOn == false)
		{
			inventoryOn = true;
			InveNtory.SetActive (true);
		}
		else if (inventoryOn == true)
		{
			inventoryOn = false;
			InveNtory.SetActive (false);
		}
	}
}
