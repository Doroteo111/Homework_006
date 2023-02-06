using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    // : Display on the console the even numbers from 0 to 100 in descending order (100, 98, 96, …) with a for loop
    void Start()
    {
       for (int i=100; i>=1; i--)
        {
            Debug.Log(i);
        }
    }

    
}
