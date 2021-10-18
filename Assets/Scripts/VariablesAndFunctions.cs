using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;
    
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log("Variables and functions: " + myInt);
    }
    
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
