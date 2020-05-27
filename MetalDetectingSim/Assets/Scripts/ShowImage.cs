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
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;

    public void Display(string icon)
    {
        Debug.Log(icon);
        if (icon == "0")
        {
            current = GameObject.Find("/Canvas/Inventory/Panel/InventorySlot/ItemButton/Icon").GetComponent<Image>();
        }
        else
        {
            current = GameObject.Find("/Canvas/Inventory/Panel/InventorySlot ("+ icon +")/ItemButton/Icon").GetComponent<Image>();
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
    public void Donate()
    {
        if (current != null)
        {
            Debug.Log(current.sprite.name);
            if (current.sprite.name == "1")
            {
                eight.SetActive(true);
            }
            if (current.sprite.name == "2")
            {
                six.SetActive(true);
            }
            if (current.sprite.name == "3")
            {
                seven.SetActive(true);
            }
            if (current.sprite.name == "4")
            {
                ten.SetActive(true);
            }
            if (current.sprite.name == "5")
            {
                nine.SetActive(true);
            }
            if (current.sprite.name == "6")
            {
                three.SetActive(true);
            }
            if (current.sprite.name == "7")
            {
                four.SetActive(true);
            }
            if (current.sprite.name == "8")
            {
                one.SetActive(true);
            }
            if (current.sprite.name == "9")
            {
                five.SetActive(true);
            }
            if (current.sprite.name == "10")
            {
                two.SetActive(true);
            }
        }
    }
}
