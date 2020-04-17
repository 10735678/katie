using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSwitches : MonoBehaviour
{

    public enum GameStates
    {
        Starting,
        Playing,
        InStore,
        Pausing,
        Ending,
    }

    public GameStates currentGameState;

    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump
    }

    public PlayerStates currentPlayerState;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                print("I am Resting");
                break;
            case PlayerStates.Walk:
                print("I am Walking");
                break;
            case PlayerStates.Run:
                print("I am Running");
                break;
            case PlayerStates.Jump:
                print("I am Jumping");
                break;
            default:
                print("I am any");
                break;
                

        }

        switch (currentGameState)
        {
            case GameStates.Starting:
                break;
            case GameStates.Playing:
                break;
            case GameStates.InStore:
                break;
            case GameStates.Pausing:
                break;
            case GameStates.Ending:
                break;
                

                throw new ArgumentOutOfRangeException();
        }
        
    }
}
