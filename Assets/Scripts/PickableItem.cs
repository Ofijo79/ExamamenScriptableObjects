using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;

    SpriteRenderer spriteRenderer;
    private int weaponLayer;
    private int armorLayer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
        weaponLayer = LayerMask.NameToLayer("Weapon");
        armorLayer = LayerMask.NameToLayer("Armor");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.layer == weaponLayer)
            {
                InventoryManager.instance.AddItemWeapon(item);
            }
            else if (gameObject.layer == armorLayer)
            {
                InventoryManager.instance.AddItemArmor(item);
            }

            Destroy(this.gameObject);
        }
    }
}
