using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assignment18 
{
    //object position 
    public struct Position 
    {
        public float X;
        public float Y;
        public float Z;

    public Position(float x, float y, float z){
        X = x;
        Y = y;
        Z = z;
    }
        public void printPosition(){
        
        Debug.Log($"position is ({X},{Y},{Z})");
    }
    }

    // //create Character base 
  public class Character{
        public string name;
        public int health;
        protected Position position;
        public void  Health( int health ){
            health=this.health;
            Mathf.Clamp (health, 0, 100);
        } 

     //store character values in variables 
        public Character (string Name, int Health, Position position ){
         name = Name;
         health = Health;
        this.position=position;
        }
        public Character() :this ("no name", 100, new Position (0,0,0)){}

      
    //display information 
    public virtual void DisplayInfo(){
        Debug.Log($"Name: {name}, Health: {health}, Position: {position}");
    }

    //Attack method
      public  void Attack(int damage, Character target){
         target.health -= damage;
    }
    public void attackType(int damage, Character target, string attackType){
        Debug.Log("shooting");
    }

  }

  //solider class inherent from character
  public class Solider:Character{
     public Solider ():base(){}

        public override void DisplayInfo()
        {
            Debug.Log("Solider");
            base.DisplayInfo();
        }
    }

//officer class inherent from character
      public class Officer:Character{
       public Officer(string name, int health, Position position): base(name, health, position) { }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }

    
}
  
