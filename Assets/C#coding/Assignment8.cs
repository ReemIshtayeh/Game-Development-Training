using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           //Exercise 1
        // int i=0;
        // while(i<21){

        //    int RandomNum=Random.Range(1, 20);
        //     if(RandomNum==5) continue; //if number is 5 countinue code witoout print num "5"
        //    else if(RandomNum==15)break; //if number is 15 break the loop and out
        //    Debug.Log(RandomNum); 
        //     i++; }
    
            //Exercise 2
            int j=0;
            string sentence="";
            int wordNum;
            string word;
            string[] animal={"Cat","Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
           
            while (j<7){
             wordNum= Random.Range(0,animal.Length-1);// get random number
            // Debug.Log(wordNum);
             word=animal[wordNum]; //get the word based on random num
             //Debug.Log(word);
             sentence=sentence + word +" ";
             word=" ";
             j++;
            }
            Debug.Log(sentence);

        
    }

    // Update is called once per frame

}
