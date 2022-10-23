using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    // Start is called before the first frame update
    int counter;
    void Start()
    {
     counter = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkIfActivate(int addToCounter)
    {
        //check if counter is 3
        counter+=addToCounter;
        if(counter == 3)
        {
            ActivateButton();
        }
    }

    void ActivateButton()
    {
        //if selected within 2 seconds, the platform comes down.
        //if not, reset the counter. 
        Invoke("DeactivateButton", 1);
    }

    void DeactivateButton()
    {
        counter = 0;
    }
}
