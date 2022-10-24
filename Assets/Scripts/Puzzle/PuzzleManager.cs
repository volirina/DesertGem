using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{

    public bool BothSwitchesAreOn;
    public bool CountdownIsOn;
    public bool PuzzleIsSolved;

    public int CountdownReset;

    public LeverA leverA ;
    public LeverB leverB;

    public AudioSource audioSource;


    void Start()
    {
        InvokeRepeating("OutputTime", 0f, 1f);  //0s delay, repeat every 1s
    }

    //Every 1 sec
    void OutputTime()
    {
        if (CountdownIsOn == true)
        {
            CountdownReset = CountdownReset + 1;
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leverA.IsTurnedOnA == true  && leverB.IsTurnedOnB == true && CountdownIsOn == false)
        {
            CountdownReset = 0;
            BothSwitchesAreOn = true;
            CountdownIsOn = true;
        }

        //reset after X seconds
        if (CountdownReset >= 20 && CountdownIsOn == true)
        {
            CountdownReset = 0;
            CountdownIsOn = false;
            BothSwitchesAreOn = false;
            leverA.IsTurnedOnA = false;
            leverB.IsTurnedOnB = false;
        }

    }
}
