using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Weapon.Armor")]
public class ScriptableItem : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor
    }

    public ItemType itemType;
    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
}
