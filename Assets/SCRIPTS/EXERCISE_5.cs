using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
    // Create a public int array. Create a private int variable. Compute the sum of the  elements of your array, store it in the
    // private variable created earlier and display the result on the console.  or example, if your array is [1, 2, 3, 4, 5]
    // , then the result displayed on the console will 1 + 2 + 3 + 4 + 5 = 15

    public int[] numbers = { 1, 2, 3, 4, 5 };
    private int otherNum;
   
    private void Start()
    {
        foreach (int number in numbers)
        {
            int sum = 1;
            otherNum = sum++;
            Debug.Log(otherNum);
        }
        
    }
    //estoy muy perdido D:
   
}
