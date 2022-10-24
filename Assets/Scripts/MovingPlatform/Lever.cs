using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public MovingPlatform movingPlatform;
    public PuzzleManager puzzleManager;
    public AudioSource audioSource;

    // Condition on mouse click
    private void OnMouseDown()
    {
        if (puzzleManager.BothSwitchesAreOn == true && puzzleManager.PuzzleIsSolved == false)
        {
            movingPlatform.TurnOn();
            audioSource.Play();
            puzzleManager.BothSwitchesAreOn = false;
            puzzleManager.CountdownReset = 30;
            puzzleManager.PuzzleIsSolved = true;
        }
    }
}
