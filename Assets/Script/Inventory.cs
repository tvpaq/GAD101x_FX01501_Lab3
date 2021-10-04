using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int projectileA;
        public int projectileB;
        public int projectileC;

        public Stuff(int prA, int prB, int prC)
        {
            projectileA = prA;
            projectileB = prB;
            projectileC = prC;
        }

        public Stuff()
        {
            projectileA = 1;
            projectileB = 1;
            projectileC = 1;
        }
    }
}
