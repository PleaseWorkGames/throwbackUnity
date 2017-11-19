using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public Hud hud;
	public Inventory inventory;
	// Use this for initialization
	void Start () {
		hud = GameObject.FindWithTag("Hud").GetComponent<Hud>();
		inventory = GetComponent<Inventory>();
		if (!inventory)
		{
			inventory = new Inventory();
		}

	}

	public void onItemPickup(Item item)
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
