using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;

    // Add item to InventoryManager and delete item from scene
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    // Condition for pickup. Currently on mouse click
    private void OnMouseDown()
    {
        Pickup();
    }

}
