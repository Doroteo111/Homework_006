using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    // Create two public variables. One will be the left end of the interval and the other  the right end.If you want, call them start
    // and end.Create a while loop that displays all multiples of 5 between start and end.
    // For example, if start = 3 and end = 27, then in the console the numbers 5, 10, 15, 20 and 25 should be displayed

    public int start = 3;
   public int end= 27;
   private int result;
 
   void Start()
   {
        result = start;
       while (start <= 27) 
       {
          Multiples();
          start++; 
       }

   }

   private void Multiples()
   {
      
       if (result % 5 == 0)
       {
           Debug.Log(result);
       }
       
   }
  
    //no entiendo nada ayudaaaaa, los bucles infinitos aaa
    //no imprime :(


}
