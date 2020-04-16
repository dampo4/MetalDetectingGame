using UnityEngine.UI;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    Item item;
    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }
    public void RemoveItem()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
