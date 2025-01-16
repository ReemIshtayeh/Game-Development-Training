using System.Collections;
using System.Collections.Generic;
// using System.Drawing;
using UnityEngine;
using System;

namespace assignment19
{
    

public class ChangeLight : MonoBehaviour
{
  public Light lightColor;

    // Update is called once per frame
    void Update()
    {    
       float transitionSpeed=  Mathf.PingPong(Time.time,2)/2;
       //change light color over time
        lightColor.color=Color.Lerp(Color.white, Color.red,transitionSpeed);
       // increase light intensity
        lightColor.intensity=Mathf.Clamp(lightColor.intensity,4f,8f);
    }
}
}