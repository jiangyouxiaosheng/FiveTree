using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;
    private SpriteRenderer spriteRenderer;
    private ItemBase itemBase;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void Init(int id)
    {
        itemID = id;
        
        itemBase = ItemManager.Instance.GetItemDetails(id);
        if (itemBase != null)
        {
            spriteRenderer.sprite = itemBase.itemIcon != null ? itemBase.itemIcon :itemBase.itemIcon ;
        }
    }
}
