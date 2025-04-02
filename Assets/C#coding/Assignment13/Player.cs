using System.Diagnostics;
using System.Threading;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;


public class Player{

   //variable for inserting name of all player in game 
    public string playerName;
    public int health;
    
   private static int playerCount = 0;
   //initialize player information 
   public void Initializedplayer (string name, int initialHealth){
    playerName=name;
    health=initialHealth;
    playerCount++ ;
   }
    
    //player health increase by healAmount
    public void Heal(int healAmount){
        healAmount +=health;
        Debug.Log($"{playerName} has {health} health");   
    }
       

       //fully restore health when set to true.
        public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log($"{playerName} fully restored. Current health: {health}");
        }
    }
      
      //keep track number of player 
        public static void ShowPlayerCount()
    {
        Debug.Log($"Total number of players: {playerCount}");
    }
   
}