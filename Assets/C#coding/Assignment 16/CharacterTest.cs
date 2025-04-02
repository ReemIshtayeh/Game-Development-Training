using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assignment18
{
public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //    Vector3 position= new Vector3(1f,5f,5f);
    //    Position position=new Position();
    //    position=(5f,5f,5f);
    
        Solider soldier = new Solider();
        Officer officer = new Officer("Reem",90, new Position(.1f ,.5f, .5f)); 
        Character[] characters=new Character[] {soldier,officer};

// run display information method  
        foreach(Character character in characters){
            character.DisplayInfo();

        }
        Debug.Log($"Solider health before attack: {soldier.health}" );
        officer.Attack(20,soldier);
        Debug.Log($"Solider health after attack: {soldier.health}");
        

    }

}
}
