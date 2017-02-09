using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics_GenerateNumber : MonoBehaviour {

    GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
        GenerateNewNumber();
        gameManagerMaster.EventRightAnswer += GenerateNewNumber;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventRightAnswer += GenerateNewNumber;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void GenerateNewNumber()
    {
        gameManagerMaster.newNumber = Random.Range(gameManagerMaster.minNumberValue, gameManagerMaster.maxNumberValue);
    }
}
