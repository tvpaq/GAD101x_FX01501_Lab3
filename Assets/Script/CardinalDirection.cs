using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardinalDirection : MonoBehaviour
{
    enum Direction {North, East, South, West};  // default type: 0, 1, 2, 3
    //enum Direction { North = 1, East, South, West };  // change: start from 1: 1, 2, 3, 4
    //enum Direction { North = 2, East = 4, South = 12, West = 24 };    // set for each value
    //enum Direction : short { North, East, South, West };  // change variable type: from "int" to "short"

    void Start()
    {
        Direction myDirection;
        myDirection = Direction.North;

        Debug.Log("my direction is " + myDirection);
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
