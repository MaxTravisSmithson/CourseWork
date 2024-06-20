using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    public static void PauseGame()
    {
        Time.timeScale = 0;
    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateGameState(GameState.Menu);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Menu:
                Menu();
                break;
            case GameState.Shop:
                break;
            case GameState.Exit:
                break;
            case GameState.Running:
                break;
            case GameState.Paused:
                break;
            case GameState.Victory:
                break;
            case GameState.Death:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }

    static void Menu()
    {
        PauseGame();
    }
}

// This uses enums for all the possible states that the game can be in
public enum GameState
{
    Menu,
    Shop,
    Exit,
    Running,
    Paused,
    Victory,
    Death
}