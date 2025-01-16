using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTransform : MonoBehaviour
{
    
    public GameObject gameobject ;
    public float rotateSpeed=20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       for(int i=0 ; i< gameobject.transform.childCount; i++){
          Transform child=gameobject.transform.GetChild(i);
           child.Rotate(0,-rotateSpeed*Time.deltaTime,0);
        
         
         }
    }
}
