using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int [5];
    //int[] myIntArray = { 12, 3, 4, 5, 23 };
    public GameObject[] players;

    void Start()
    {
        myIntArray[0] = 12;
        myIntArray[1] = 3;
        myIntArray[2] = 4;
        myIntArray[3] = 5;
        myIntArray[4] = 23;

        players = GameObject.FindGameObjectsWithTag("Player"); //array all game objects with the tag

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player number " + i + " is " + players[i].name);
        }
    }
}
