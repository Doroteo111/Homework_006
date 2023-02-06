using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    // Display 20 times on the console the message “Hola, holita, vecinito” with a while loop

    private int i = 0;
    public string names= "Hola, holita, vecinito";
    void Start()
    {
       while (i < 20)
        {
            Debug.Log(names);
            i++;
        }
    }

   
}
