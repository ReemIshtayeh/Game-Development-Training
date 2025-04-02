using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14{
public class Player :  Character
{
    public Player (string name, int health ):base(name,health){}

 public void Heal(){
    int amount=10;
    Health+=amount;
    Debug.Log($"player {Name} heals by {amount} your health is now {Health}");
  
 }
}
}