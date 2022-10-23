using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define Scriptable object. Allow to create objects
[CreateAssetMenu(fileName ="New Item",menuName ="Item/Create New Item")]

// Determine the properties of all items
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
    public ItemType itemType;

    public enum ItemType
    {
        Potion,
        Sword,
        Key,
        Gem
    }
}
