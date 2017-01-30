using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleControl : MonoBehaviour
{

    private int room, currentPuzzle, puzzlePhase;
    private string selectedInvItem,thingClicked;
    //
    private bool isDisturbed;

    //I'm hoping that we can just use this one script on the girl to control all "states" of a room based on where in the puzzle the girl is

    // Use this for initialization
    void Start()
    {
        room = 1;
        currentPuzzle = 1;
        puzzlePhase = 1;
        isDisturbed = false;
        selectedInvItem = "empty";
        thingClicked = "nothing";
    }

    // Update is called once per frame
    void Update()
    {
        if (room == 1 && currentPuzzle == 1)
        {
            //12 phases total - refer to sheet
            //This portion for puzzle solution actions
            if (puzzlePhase == 1)
            {
                //Starting phase of room
            }
            //This portion for flavor text and interactions that are the same for multiple phases
        }
        else if (room == 1)
        {
            //same as puzzlePhase==12 and any flavor texts that function at that time
        }

    }
    void setThingClicked(string clicked)
    {
        thingClicked = clicked;
    }
    void setInvItem(string item)
    {
        selectedInvItem = item;
    }
    void flipWorlds()
    {
        isDisturbed = !isDisturbed;
    }
}
