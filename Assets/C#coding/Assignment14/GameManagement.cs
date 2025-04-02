using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace Assignment14{
public class GaameManagement : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Player player=new Player("AbuObaida",100);
        Enemy enemy=new Enemy("Gun",100);
        
        Debug.Log($"Player name :{player.Name}, Health is {player.Health}");
        Debug.Log($"Enemy name :{enemy.Name}, Health is {enemy.Health}");
        
        player.Heal();
        Debug.Log($"After healing player health is {player.Health}");

            
        enemy.Attack(player);
        Debug.Log($"After Attack, player health is {player.Health}");

    }

  
}
 }