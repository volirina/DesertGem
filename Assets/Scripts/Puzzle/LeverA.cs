using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverA : MonoBehaviour
{
    public PuzzleManager puzzleManager ;
    public AudioSource audioSource;

    public bool IsTurnedOnA;


    // Condition on mouse click
    private void OnMouseDown()
    {
        if (puzzleManager.PuzzleIsSolved == false)
        {
            IsTurnedOnA = true;
            audioSource.Play();
        }
    }
}
