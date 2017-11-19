using UnityEngine;

public class Hud : MonoBehaviour
{
    public Texture2D inventoryBox;

    void Start()
    {
        inventoryBox = Resources.Load("sprites/gui/InventoryBar") as Texture2D;
        Debug.Log(inventoryBox);
        
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), inventoryBox);
    }
}
