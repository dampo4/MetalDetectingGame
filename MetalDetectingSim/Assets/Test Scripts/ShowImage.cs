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

    private void Start()
    {
        GameObject.Find("/PIC-FRAME-FBX/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (1)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (1)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (2)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (2)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (3)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (3)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (4)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (4)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (5)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (5)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (6)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (6)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (7)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (7)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (8)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (8)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (9)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (9)/Plane").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (10)/Museum Display").SetActive(false);
        GameObject.Find("/PIC-FRAME-FBX (10)/Plane").SetActive(false);
    }
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
                GameObject.Find("/PIC-FRAME-FBX (2)/Museum Display").SetActive(false);
                GameObject.Find("/PIC-FRAME-FBX (2)/Plane").SetActive(false);
            }
            if (current.sprite.name == "2")
            {
                GameObject.Find("/PIC-FRAME-FBX (3)/Museum Display").SetActive(false);
                GameObject.Find("/PIC-FRAME-FBX (3)/Plane").SetActive(false);
            }
            if (current.sprite.name == "3")
            {
                GameObject.Find("/PIC-FRAME-FBX (4)/Museum Display").SetActive(false);
                GameObject.Find("/PIC-FRAME-FBX (4)/Plane").SetActive(false);
            }
            if (current.sprite.name == "4")
            {
                GameObject.Find("/PIC-FRAME-FBX/Museum Display").SetActive(false);
                GameObject.Find("/PIC-FRAME-FBX/Plane").SetActive(false);
            }
            if (current.sprite.name == "5")
            {
                GameObject.Find("/PIC-FRAME-FBX (1)/Museum Display").SetActive(false);
                GameObject.Find("/PIC-FRAME-FBX (1)/Plane").SetActive(false);
            }
            if (current.sprite.name == "6")
            {
                GameObject.Find("/PIC-FRAME-FBX (6)/Museum Display").SetActive(true);
                GameObject.Find("/PIC-FRAME-FBX (6)/Plane").SetActive(true);
            }
            if (current.sprite.name == "7")
            {
                GameObject.Find("/PIC-FRAME-FBX (5)/Museum Display").SetActive(true);
                GameObject.Find("/PIC-FRAME-FBX (5)/Plane").SetActive(true);

            }
            if (current.sprite.name == "8")
            {
                GameObject.Find("/PIC-FRAME-FBX (7)/Museum Display").SetActive(true);
                GameObject.Find("/PIC-FRAME-FBX (7)/Plane").SetActive(true);
            }
            if (current.sprite.name == "9")
            {
                GameObject.Find("/PIC-FRAME-FBX (8)/Museum Display").SetActive(true);
                GameObject.Find("/PIC-FRAME-FBX (8)/Plane").SetActive(true);
            }
            if (current.sprite.name == "10")
            {
                GameObject.Find("/PIC-FRAME-FBX (9)/Museum Display").SetActive(true);
                GameObject.Find("/PIC-FRAME-FBX (9)/Plane").SetActive(true);
            }
        }
    }
}
