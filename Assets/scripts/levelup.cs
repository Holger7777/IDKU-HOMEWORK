using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour
{

    public string Class = "Paladin";
    private int Level = 1;
    public string Name = "Morgana";

    // Here is the first Strings and Int dinfied, the character starts at level 1 with the class Paladin and the Name Morgana. 


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Calling(Name, Level)); // here is the printed variable updated 
        Debug.Log(Class + (Name));
    }

    // the method used is for updating the level and printing both the start level + the ammount of levels that go up. 
    private int Calling(string name, int level)
    {
        Debug.Log(level); //prints level 
        level++; // when the consol starts, there will be a change of level of +1 

        return level+=5; // here is the return that prints the Level + 1 + 5 
    }
}
