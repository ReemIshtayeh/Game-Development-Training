using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace assignment19 {

public class Transforming : MonoBehaviour

{
  
    public GameObject gameobject ;
    public float rotateSpeed=20f;
//    GameObject gameobject= new GameObject();
    
    // Start is called before the first frame update
    void Start()
    {
        //code write name of Top's children
        
        //   gameobject = GameObject.Find("Top");
        // for(int i=0 ; i< gameobject.transform.childCount; i++){
        //   Debug.Log(gameobject.transform.GetChild(i).name);
        //  }
        

    }
        
   

    // Update is called once per frame
    void Update()
    {
          //get and transform object's children 
       
       for(int i=0 ; i< gameobject.transform.childCount; i++){
          Transform child=gameobject.transform.GetChild(i);
          child.Rotate(0,rotateSpeed*Time.deltaTime,0);
         
         }

    }
}
}
