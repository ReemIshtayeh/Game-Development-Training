using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            //Specific Requirements in part 1
            var a = 5;
            //var stringVal = "Reem";
           // var boolVal = true;
            string result = a % 2 == 1 ? "odd" : "even";
            Debug.Log($"The number {a} is {result}");
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now);
            Debug.Log(System.DateTime.Now.Day);
        }

      
    }
}