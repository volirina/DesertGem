using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverB : MonoBehaviour
{
    public PuzzleManager puzzleManager ;
    public AudioSource audioSource;

    public bool IsTurnedOnB;


    // Condition on mouse click
    private void OnMouseDown()
    {
        if (puzzleManager.PuzzleIsSolved == false)
        {
            IsTurnedOnB = true;
            audioSource.Play();
        }
    }
}
