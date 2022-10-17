using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleEquipment : MonoBehaviour
{
    public Image swordImage;

    // Hide UI sword icon at begining
    void Start()
    {
        swordImage.enabled = false;
    }

    // Show UI sword icon when picked up
    public void ChangeSwordIcon()
    {
            swordImage.enabled = true;

    }
}
