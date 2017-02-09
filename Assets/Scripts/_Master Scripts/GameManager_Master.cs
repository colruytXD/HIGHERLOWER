using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPauseGame;
    public event GeneralEventHandler EventExitGame;
    public event GeneralEventHandler EventRightAnswer;
    public event GeneralEventHandler EventWrongAnwer;

    public delegate void SceneLoadManager(int SceneNr);

    public event SceneLoadManager EventGoToMainMenu;
    public event SceneLoadManager EventGoToGameMenu;

    public void CallEventPauseGame()
    {
        EventPauseGame();
    }

    public void CallEventExitGame()
    {
        EventExitGame();
    }

    public void CallEventRightAnswer()
    {
        EventRightAnswer();
    }

    public void CallEventWrongAnwer()
    {
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
}
