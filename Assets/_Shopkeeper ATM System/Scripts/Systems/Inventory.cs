using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private Inventory_Data inventoryData;
    [SerializeField] private GameObject inventory_Panel;
    [SerializeField] private Transform itemsParent;

    void Start()
    {
        GameObject go;
        foreach (Item_Data itemData in inventoryData.InventoryItems)
        {
            go = Instantiate(itemPrefab, itemsParent);
            go.GetComponent<InventoryItem>().SetItemData(itemData);
            go.GetComponent<InventoryItem>().SetHoldingInventory(inventoryData);
        }
    }

    public void OnButtonClick_OpenPanel()
    {
        inventory_Panel.SetActive(true);
    }
}
