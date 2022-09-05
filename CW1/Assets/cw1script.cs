using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw1script : MonoBehaviour
{
    string heroName = "Spark";
    float heroHeight = 1.80f;
    int heroAge = 24;
    string heroSuperPower = "speed";
    string villianName = "Cora";
    float villianHeight = 1.87f;
    int villianAge = 21;
    string villianSuperPower = "Shape shifting";
   

    
    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - villianAge;
        print("i am the Hero snd my name is " + heroName);
        print("my Height is " + heroHeight + " and my age is " + heroAge);
        print("My super power is " + heroSuperPower);
        print("i am the villian snd my name is " + villianName);
        print("my Height is" + villianHeight + " and my age is " + villianAge);
        print("My super power is " + villianSuperPower);
        print("the age difference is " + ageDifference);

        //bonus
        heroHeight = heroHeight + 5;
        villianSuperPower = "None";
        print("i am the Hero snd my name is " + heroName);
        print("my Height is " + heroHeight + " and my age is" + heroAge);
        print("My super power is " + heroSuperPower);
        print("i am the villian snd my name is " + villianName);
        print("my Height is" + villianHeight + " and my age is " + villianAge);
        print("My super power is " + villianSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
