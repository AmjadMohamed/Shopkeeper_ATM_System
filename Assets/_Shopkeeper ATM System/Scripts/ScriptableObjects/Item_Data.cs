using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory_Item")]
public class Item_Data : ScriptableObject
{
    public string Name;
    public Sprite ImageSprite;
    public int Cost;
}
