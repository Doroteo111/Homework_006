using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
    // Make a countdown with a for loop. You will need a public variable of type integer 
    //to decide from which number to start counting down.
    public int number = 14;
    
    void Start()
    {

        for(int i=number; i>=0; i--)
        {
            Debug.Log(i);
        }

    }

    
}
