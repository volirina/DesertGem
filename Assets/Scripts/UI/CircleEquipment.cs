using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleEquipment : MonoBehaviour
{
    public Image swordImage;

    // Start is called before the first frame update
    void Start()
    {
        swordImage.enabled = false;
    }

    // Update is called once per frame
    public void ChangeSwordIcon()
    {
            swordImage.enabled = true;

    }
}
