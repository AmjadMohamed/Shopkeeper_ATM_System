using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler
{
    [SerializeField] private Inventory_Data inventoryData;
    [SerializeField] private Transform itemsParent;
    [SerializeField] private bool isPlayerInventory;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;
        DraggableItem draggableItem = droppedObject.GetComponent<DraggableItem>();
        InventoryItem inventoryItem = droppedObject.GetComponent<InventoryItem>();
        if (droppedObject.transform.parent != itemsParent && inventoryItem != null)
        {
            if (isPlayerInventory) // buying the item
            {
                if (UIManager.Instance.PlayerData.CoinBalance >= inventoryItem.Data.Cost)
                {
                    draggableItem.UpdateParent(itemsParent);
                    UIManager.Instance.UpdateCoinBalance(-inventoryItem.Data.Cost);
                }
                else
                {
                    FeedbackText.Instance.ShowFeedbackText("You Don't Have Enough Money To Buy This Item!");
                }
            }
            else // selling the item
            {
                draggableItem.UpdateParent(itemsParent);
                UIManager.Instance.UpdateCoinBalance(inventoryItem.Data.Cost);
            }

            inventoryItem.LastHoldingInventoryData.RemoveItem(inventoryItem.Data);
            inventoryData.AddItem(inventoryItem.Data);
            inventoryItem.SetHoldingInventory(inventoryData);
        }


    }


}
