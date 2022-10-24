using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_OpenDoor : MonoBehaviour
{
    public MovingPlatform movingPlatform;
    public DestroyOnCall destroy;
    public RPG.Combat.Fighter fighter;
    public AudioSource audioSource;

    // Condition on mouse click
    private void OnMouseDown()
    {
        if (fighter.HavetheKey == true)
            {
            movingPlatform.TurnOn();
            destroy.PyramidOnCall();
            Destroy(gameObject);
            audioSource.Play();
        }

    }

}
