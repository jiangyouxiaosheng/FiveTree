using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : ModuleSingleton<ItemManager>, IModule
{


    public ItemDataLise_SO itemDataLise_SO;


    public ItemBase  GetItemDetails(int ID)
    {
        return itemDataLise_SO.itemBase.Find(i => i.itemId == ID);
    }





    public void OnCreate(object createParam)
    {
       
    }

    public void OnUpdate()
    {
       
    }
}
