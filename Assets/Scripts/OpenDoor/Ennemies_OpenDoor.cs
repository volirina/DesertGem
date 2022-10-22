using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemies_OpenDoor : MonoBehaviour
{
    public MovingPlatform movingPlatform;
    public RPG.Combat.Fighter fighter;

    // Condition on mouse click
    private void Update()
    {
        if (fighter.EnnemiesKilled >= 3)
        {
            movingPlatform.TurnOn();
            Destroy(gameObject);

        }

    }
}
