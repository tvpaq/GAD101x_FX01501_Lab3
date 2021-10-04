using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;
    // Start is called before the first frame update
    void Start()
    {
        Greet();
    }


    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Hello! Let me teach you about abc...");
                break;
            case 4:
                print("Hello, have a good day");
                break;
            case 3:
                print("What up");
                break;
            case 2:
                print("Grog Smash");
                break;
            case 1:                                                               
                print("adfa nk ioid");
                break;
            default:
                print("Incorrect intelligence level");
                break;
        }
    }
}
