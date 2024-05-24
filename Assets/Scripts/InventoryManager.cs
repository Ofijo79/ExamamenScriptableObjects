using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;

    public Text[] weaponsNames;
    
    public Text[] weaponsPrice;

    public Image[] weaponsSprites;

    public InventorySlots[] weaponSlots;

    public ScriptableItem[] armor;

    public Text[] armorNames;

    public Text[] armorPrice;

    public Image[] armorSprites;

    public InventorySlots[] armorSlots;


    void Awake()
    {
        instance = this;
    }
    
    public void AddItemWeapon(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsPrice[i].text = item.itemPrice.ToString();
                weaponsSprites[i].sprite = item.itemSprite;

                weaponSlots[i].slotItem = item;
                weaponSlots[i].slotNumber = i;

                return;
            }
        }
    }

    public void AddItemArmor(ScriptableItem item)
    {
        for (int i = 0; i < armor.Length; i++)
        {
            if(armor[i] == null)
            {
                armor[i] = item;
                armorNames[i].text = item.itemName;
                armorPrice[i].text = item.itemPrice.ToString();
                armorSprites[i].sprite = item.itemSprite;

                armorSlots[i].slotItem = item;
                armorSlots[i].slotNumber = i;

                return;
            }
        }
    }
}
