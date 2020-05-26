using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    private Image current;
    public Image display;
    public GameObject player;
    public GameObject museum;
    public GameObject forest;
    private CharacterController controller;
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
        controller = player.GetComponent<CharacterController>();
        controller.enabled = false;
        if (destination == "Museum")
        {
            player.transform.position = museum.transform.position;
        }
        else if (destination == "Forest")
        {
            player.transform.position = forest.transform.position;
        }
        controller.enabled = true;
    }
}
