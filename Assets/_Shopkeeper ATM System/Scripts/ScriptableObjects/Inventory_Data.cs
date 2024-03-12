using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory")]
public class Inventory_Data : ScriptableObject
{
    public List<Item_Data> InventoryItems = new List<Item_Data>();

    public void AddItem(Item_Data itemData)
    {
        if (InventoryItems.Contains(itemData))
            return;
        InventoryItems.Add(itemData);
    }

    public void RemoveItem(Item_Data itemData)
    {
        if (InventoryItems.Contains(itemData))
        {
            InventoryItems.Remove(itemData);
        }
    }
}
