using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleControl : MonoBehaviour
{

    private int room, currentPuzzle, puzzlePhase;
    private string selectedInvItem;
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
