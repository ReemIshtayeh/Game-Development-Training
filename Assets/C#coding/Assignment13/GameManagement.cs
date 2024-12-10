
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
  //call file player in variable aboObaida and alSenwar
  Player aboObaida=new Player(); 
  Player alSenwar=new Player();

  //set playerName and health for each player 
  aboObaida.Initializedplayer("aboObaida",100);
  alSenwar.Initializedplayer("alSenwar",10);

 //heal the player in the game
   aboObaida.Heal(0);
   alSenwar.Heal(true);

    //show number of players
   Player.ShowPlayerCount();
   }

}

