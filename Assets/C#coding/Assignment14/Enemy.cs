using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14{
public class Enemy : Character
{
     public  Enemy(string name, int health) : base(name, health) { }

    // Start is called before the first frame update
  public void Attack(Character target){
    int damageAmount = 10;
    target.Health-=damageAmount;
    Debug.Log($"player {Name} is attacked by enemy {target.Name} for {damageAmount} damage. Target health is now {target.Health}.");
    
  }

}
}