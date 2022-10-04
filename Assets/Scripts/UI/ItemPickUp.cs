using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;


    void Pickup()
    {
        //Add item to inventory
        InventoryManager.Instance.Add(Item);

        //Destroy pickable item
        Destroy(gameObject);

        //update inventory if iopen
        InventoryManager.Instance.ListItems();

    }

    // Condition for pickup. Currently on mouse click
    private void OnMouseDown()
    {
        Pickup();
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pickup();
        }

    }*/


}
