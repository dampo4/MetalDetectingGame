using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] slots;
    int count = 0;

    private void Start()
    {
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
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
