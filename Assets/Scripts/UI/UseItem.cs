using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public Item items;
    public RPG.Core.Health playerHealth;
    public InventoryItemController inventoryItemController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void UsePotion()
     {
         if (items.itemName == "RedPotion")
         {
            inventoryItemController.RemoveItem();
            Debug.Log("RedPotion");

        }

        /*switch (items.itemType)
          {
              case Item.ItemType.Potion:
                  playerHealth.IncreaseHealth(items.value);
                  break;
          }*/

        /*RemoveItem(); */
    }
}
