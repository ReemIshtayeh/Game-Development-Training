using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UIElements;

public class Dolldancing : MonoBehaviour
{
    //variables to rotate object
    public Vector3 rotateDeg = new Vector3 (0,1,0); // rotate in y Axis
    public float rotateInc=40f; //rotate increamental
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         
   
      if(Input.GetKey(KeyCode.RightArrow)){
       Debug.Log("Right Arrow Pressed");
        transform.Rotate( rotateDeg * rotateInc * Time.deltaTime);
    }


      else if (Input.GetKey(KeyCode.LeftArrow)){
        Debug.Log("Left Arrow Pressed");
         transform.Rotate(-rotateDeg * rotateInc * Time.deltaTime );
      }
         
       
    }
}
