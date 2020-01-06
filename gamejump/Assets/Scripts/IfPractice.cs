using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPractice : MonoBehaviour
{
    public float cowCount = 5;
    public float mostCowCount = 10;
    public float leastCowCount = 1;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CowCountTest();

        cowCount -= Time.deltaTime * 5f;
    }

    void CowCountTest()
    {
        if (cowCount > mostCowCount)
        {
            print("Where are the cows?");
        }
        else if (cowCount < leastCowCount)
        {
            print("All the cows");
        }
        else
        {
            print("Cows");
        }
    }
}
