using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

    [SerializeField]
    public int maxNumberValue, minNumberValue;

    public int oldNumber;
    public int newNumber;

    public bool isPaused = false;

    public int currentScore;
    public int HighScore;

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPauseGame;
    public event GeneralEventHandler EventExitGame;
    public event GeneralEventHandler EventRightAnswer;
    public event GeneralEventHandler EventWrongAnwer;

    public delegate void SceneLoadManager(int SceneNr);

    public event SceneLoadManager EventGoToMainMenu;
    public event SceneLoadManager EventGoToGameMenu;

    public void CallEventTogglePauseGame()
    {
        isPaused = !isPaused;
        EventPauseGame();
    }

    public void CallEventExitGame()
    {
        EventExitGame();
    }

    public void CallEventRightAnswer()
    {
        Debug.Log("Right answer");
        EventRightAnswer();
    }

    public void CallEventWrongAnwer()
    {
        Debug.Log("Wrong answer");        
        EventWrongAnwer();
    }

    public void CallEventGoToMainMenu()
    {
        EventGoToMainMenu(0);
    }

    public void CallEventGoToGameMenu()
    {
        EventGoToGameMenu(1);
    }

    void Awake()
    {
        oldNumber = Random.Range(minNumberValue, maxNumberValue);
        HighScore = PlayerPrefs.GetInt("Highscore");
    }
}
