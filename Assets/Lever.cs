using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public MovingPlatform movingPlatform;


    // Condition on mouse click
    private void OnMouseDown()
    {
        movingPlatform.TurnOn();
    }
}
