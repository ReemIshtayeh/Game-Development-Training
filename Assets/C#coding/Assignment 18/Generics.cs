using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using System;

 namespace Generics
 {
    
 
public class GameContainer<T>{
//set and get any type of item 
  private T _item;

  public void SetItem(T item){
      _item= item;
    
  }

  public T GetItem(){
   return _item;
  }

//GameUtils tht contain descripe item 

}

public class GameUtils{
    public static string DescripeItem <T>( T something){
         return $"This item is a {something}";
    }
}

}