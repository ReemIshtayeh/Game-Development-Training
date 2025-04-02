using System;
using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

 namespace Generics
 {
    
public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //inherint from GameContainer set value and stor it then show the result of get and set method
     GameContainer<string> strSentence= new GameContainer<string>();
     strSentence.SetItem("Healing Potion");
     string saveStr=strSentence.GetItem();
     Debug.Log($"Saved Item: {saveStr} " );

     //inherent from GameUtils to access DescribeItem method
    // GameUtils desSentence= new GameUtils();
    string result =GameUtils.DescripeItem(saveStr);
    Debug.Log(result);

    }

}
 }