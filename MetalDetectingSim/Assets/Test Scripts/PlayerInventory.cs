using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] slots

    private void Start()
    {
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }
    public void UpdateUI(Item item)
    {
        Debug.Log("Updating UI"+ item.name);

    }
}
