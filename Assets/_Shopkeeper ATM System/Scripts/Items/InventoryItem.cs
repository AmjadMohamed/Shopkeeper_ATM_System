using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class InventoryItem : MonoBehaviour
{
    [Header("Item Data")]
    public Item_Data Data;
    private Inventory_Data lastHoldingInventoryData;
    [Space]
    [Header("Item Properties")]
    [SerializeField] private TMP_Text ItemName;
    [SerializeField] private Image ItemImage;
    [SerializeField] private TMP_Text ItemCost;

    public Inventory_Data LastHoldingInventoryData => lastHoldingInventoryData;

    public void SetItemData(Item_Data itemData)
    {
        Data = itemData;
        ItemName.text = Data.Name;
        ItemImage.sprite = Data.ImageSprite;
        ItemCost.text = Data.Cost.ToString();
    }

    public void SetHoldingInventory(Inventory_Data inventoryData)
    {
        lastHoldingInventoryData = inventoryData;
    }
}
