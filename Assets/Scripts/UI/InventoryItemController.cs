using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    public Item items;
    public RPG.Core.Health playerHealth;


    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(items);

        Destroy(gameObject);
    }

    public void AddItem (Item newItem)
    {
        items = newItem;
    }

     public void UseItem()
     {
         /* if (Item.itemName == "RedPotion")
         {

              RemoveItem();

          }*/

         switch (items.itemType)
           {
               case Item.ItemType.Potion:
                   playerHealth.IncreaseHealth(items.value);
                   break;
           }

    RemoveItem(); 
    }

}
