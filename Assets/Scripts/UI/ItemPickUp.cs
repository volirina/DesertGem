using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;
    public RPG.Combat.Fighter fighter;
    public CircleEquipment circleEquipment;

    //Main event when picking an item
    void Pickup()
    {

        //Equip Sword if item is a Sword
        if (Item.itemName == "Sword")
        { 

        fighter.EquipSword();
        circleEquipment.ChangeSwordIcon();

        }

        //Add item to inventory
        InventoryManager.Instance.Add(Item);

        //Destroy pickable item
        Destroy(gameObject);

        //update inventory if open
        InventoryManager.Instance.ListItems();

    }

    // Condition for pickup. Currently on mouse click
    private void OnMouseDown()
    {
        Pickup();
    }


    //test for picking up items on contact, dosnt work yet ^^

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pickup();
        }

    }*/


}
