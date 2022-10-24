using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateCounter(int addCounter)
    {
        counter+=addCounter;
        //check if counter is 3
        if(counter==3)
        {
            ActivateButton();
        }
    }

    void ActivateButton()
    {
        //if selected within 2 seconds, the platform comes down.
        //if not, reset the counter. 
        Invoke("DeactivateButton", 5);
    }

    void DeactivateButton()
    {
<<<<<<< HEAD
        //GroundButton.Reset();
=======
        /*GroundButton.Reset();*/
>>>>>>> ea865ddcc1536c54b2e8a8bb9f7c9dc98b3c1215
    }
}

