using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] slots;
    int count = 0;
    private Canvas canvasObject;
    private void Start()
    {
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        canvasObject = gameObject.GetComponent<Canvas>();
        canvasObject.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown("i") || Input.GetKeyDown("e"))
        {

            canvasObject.enabled = !canvasObject.enabled;
            if (canvasObject.enabled)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
    public void UpdateUI(Item item)
    {
        Debug.Log("Updating UI"+ item.name);
        for (int i = 0; i < slots.Length; i++)
        {
            if (i == count)
            {
                slots[i].AddItem(item);
                
            }
            else if(i > count)
            {
                slots[i].RemoveItem();
            }
        }
        count += 1;
    }
}
