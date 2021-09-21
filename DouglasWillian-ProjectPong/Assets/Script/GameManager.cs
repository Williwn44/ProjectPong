using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallBase ballBase;

    public static GameManager Instance;

    public float TimeToSetBallFree = 1f;

    public StateMachine stateMachine;

    public List<Player> players;

    [Header("Menus")]
    public GameObject uiMainMenu;

    private void Awake()
    {
        Instance = this;
    }
    public void ResetPlayers()
    {
        foreach(var Player in players)
        {
            Player.ResetPlayer();
        }
    }
    public void ResetBall()
    {
        ballBase.CanMove(false);
        ballBase.ResetBall();
        Invoke(nameof(SetBollFree), TimeToSetBallFree);
    }

    public void SetBollFree()
    {
        ballBase.CanMove(true);
    }
    
    public void StartGame()
    {
        ballBase.CanMove(true);
    }

    public void EndGame()
    {
        stateMachine.SwitchState(StateMachine.States.END_GAME);
    }

    public void ShowMainMenu()
    {
        uiMainMenu.SetActive(true);
        ballBase.CanMove(false);
    }

}
