using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    private Image current;
    public Image display;
    public void Display(int icon)
    {
        Debug.Log(icon);
        if (icon == 0)
        {
            current = GameObject.Find("/Canvas/Inventory/Panel/InventorySlot/ItemButton/Icon").GetComponent<Image>();
        }
        else
        {
            current = GameObject.Find("/Canvas/Inventory/Panel/InventorySlot(" + icon + ")/ItemButton/Icon").GetComponent<Image>();
        }
        Debug.Log(current.sprite.name);
        display.sprite = current.sprite;
        display.enabled = true;
    }
    public void TeleportTo(string destination)
    {
        if (destination == "Museum")
        {

        }
        else if (destination == "Forest")
        {

        }
    }
}
