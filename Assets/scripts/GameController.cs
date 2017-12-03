﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public Hud hud;
	public Inventory inventory;

	void Start () {
		hud = GameObject.FindGameObjectWithTag("Hud")
			.gameObject
			.GetComponent<Hud>();
		inventory = GetComponent<Inventory>();
		if (!inventory)
		{
			inventory = new Inventory();
		}
	}

	public void OnItemPickup(Item item)
	{
		inventory.add(item);
		hud.renderInventory(inventory);
	}

	public void OnItemDestroyed(string itemName)
	{
		inventory.remove(itemName);
		hud.renderInventory(inventory);
	}
		
}
