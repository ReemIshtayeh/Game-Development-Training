using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update

// function of multiplying
int Multiply( int Num1, int  Num2)
        {
          return (Num1*Num2);
        }    
        
        void Start()
    {
        // Multiplication Table for 5
        int number=5;
        int result=0;
         for (int i=0; i<=10; i++){
          result=Multiply(number,i);
          Debug.Log("5" + "*" + i + "=" +result);
      
         }
    }


}
