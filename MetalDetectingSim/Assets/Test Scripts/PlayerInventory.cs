using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public void UpdateUI(Item item)
    {
        Debug.Log("Updating UI"+ item.name);
    }
}
