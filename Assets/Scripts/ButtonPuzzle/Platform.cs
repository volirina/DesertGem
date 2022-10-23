using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Vector3 finalPos;
    public float moveIncrementation;

    void Update()
    {
        MoveForPlayer();
    }
    void MoveForPlayer()
    {
        while(transform.position != finalPos)
        {
            transform.Translate(0,0,2);
        }
    }
}
