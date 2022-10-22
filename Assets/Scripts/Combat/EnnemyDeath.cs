using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyDeath : MonoBehaviour
{
    public RPG.Combat.Fighter fighter;

    public void IncrementDeathCounter()
    {
        fighter.EnnemiesKilled = fighter.EnnemiesKilled+1;
    }
}
