using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;
    public RPG.Combat.Fighter fighter;
    public CircleEquipment circleEquipment;
    public AudioSource pickupSFX;

    //Main event when picking an item
    void Pickup()
    {

        //Equip Sword if item is a Sword
        if (Item.itemName == "Sword")
        { 

        fighter.EquipSword();
        circleEquipment.ChangeSwordIcon();

        }

        //Turn true the bool for the key
        if (Item.itemName == "Key")
        {
            fighter.HavetheKey = true;

        }

        if(Item.itemName == "Gem")
        {
            SceneManager.LoadScene("Win");
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
        pickupSFX.Play();
        Pickup();
    }


}
