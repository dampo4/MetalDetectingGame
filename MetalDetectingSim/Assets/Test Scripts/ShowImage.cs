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
    //private Vector3 museum = new Vector3(63.04f, 7.73f, 23.49f);
    //private Vector3 forest = new Vector3(206.1f, 6.659f, 151.4f);
    private CharacterController test;
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
        test = player.GetComponent<CharacterController>();
        //Time.timeScale = 1;
        test.enabled = false;
        if (destination == "Museum")
        {
            Debug.Log("got here");
            player.transform.position = museum.transform.position;
        }
        else if (destination == "Forest")
        {
            player.transform.position = forest.transform.position;
        }
        test.enabled = true;
    }
}
