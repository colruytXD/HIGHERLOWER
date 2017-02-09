using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics_CheckIfPlayerRight : MonoBehaviour {

    GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
        SetInitialReferences();
	}

	void OnDisable() 
	{
		
	}

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    public void PlayerChoseHigher()
    {
        if(gameManagerMaster.oldNumber < gameManagerMaster.newNumber)
        {
            gameManagerMaster.oldNumber = gameManagerMaster.newNumber;
            gameManagerMaster.CallEventRightAnswer();
        }
        else
        {
            gameManagerMaster.CallEventWrongAnwer();
        }
    }

    public void PlayerChoseLower()
    {
        if(gameManagerMaster.oldNumber > gameManagerMaster.newNumber)
        {
            gameManagerMaster.oldNumber = gameManagerMaster.newNumber;
            gameManagerMaster.CallEventRightAnswer();
        }
        else
        {
            gameManagerMaster.CallEventWrongAnwer();
        }
    }
}
