using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListing 
{
	public int quantity;
	public Item item;

	public ItemListing(Item item) 
	{
		this.item = item;
		this.quantity = 1;
	}
}

public class Inventory : MonoBehaviour {
	
	private List<ItemListing> itemList;

	void Start() 
	{

		itemList = new List<ItemListing> ();
	}

	void addItem (Item item) 
	{ 
		bool found = false;
		foreach (ItemListing listing in itemList) {
			if (listing.item.name == item.name) {
				found = true;
				listing.quantity++;
				break;
			}
		}
		if (!found) {
			itemList.Add (new ItemListing (item));
		}
	}

	void removeItem(string name) 
	{
		foreach (ItemListing listing in itemList) {
			if (listing.item.name == name) {
				listing.quantity--;
				if (listing.quantity < 1) {
					itemList.Remove (listing);
				}
				break;
			}
		}
	}
}
