using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogicalOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //Question 1
    //   bool isSuccess=true;
    //   bool isGoodTreat=true;
    //   bool isRish=false;
    //   bool isHasCar=false;
    //   bool woow=(isSuccess&&isGoodTreat);
    //   Debug.Log(woow);
    //   woow=isGoodTreat && isRish;
    //   Debug.Log(woow);
    //   woow=isHasCar && isRish;
    //   Debug.Log(woow);
    //   woow=isSuccess || isRish;
    //   Debug.Log(woow);
    //   woow=isHasCar || isRish;
    //   Debug.Log(woow);
    //   Debug.Log (!isGoodTreat);
    //   Debug.Log(!(isSuccess || isRish));
    //   Debug.Log((5 > 3) && (2 < 4)) ;
    //   Debug.Log((10 == 10) || (5 != 5));
    //   Debug.Log((3 >= 2) && !(6 < 3));
   
    //Question 2
    // int x=3;
    // int y=5;

    // Debug.Log( (5 + 3) * 2 - 4 / 2);
    // Debug.Log(10 - 3 * 2 + 4);
    // Debug.Log(2 + 3 * 4 > 10 && 4 <= 4);
    // Debug.Log(!(10 >= 5) || 7 != 3);
    // Debug.Log((8 % 3 + 2) * 4 - 6);
    // Debug.Log(10 == 5 + 5 && 4 > 2 || 3 < 1);
    // Debug.Log(++x * 2 - --y / 2 );
    // Debug.Log((4 + 5 * 2) != 13 || (6 / 2 == 3));
    // Debug.Log(6 >= 3 * 2 && (5 % 2 == 1));

    //Question 3
    int playerLive=3;
    string playerHAS="";
    while(playerLive>1){
        Debug.Log(playerHAS="Many lives");
        playerLive--;
    }
    while(playerLive==1){
        Debug.Log(playerHAS="one lives");
        playerLive--;
    }

      while(playerLive==0){
        Debug.Log(playerHAS="Game Over");
        break;
    }
 

      
    // Update is called once per frame
    void Update()
    {
        
    }

    }
}