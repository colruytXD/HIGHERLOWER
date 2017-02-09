using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;

public class Mechanics_DisplayOldNumber : MonoBehaviour {

    GameManager_Master gameManagerMaster;
    Text txtOldNr;

	void OnEnable() 
	{ 
		SetInitialReferences();
        gameManagerMaster.EventRightAnswer += DisplayOldNumber;
        txtOldNr.text = gameManagerMaster.oldNumber.ToString();
    } 
	
	void OnDisable() 
	{
        gameManagerMaster.EventRightAnswer += DisplayOldNumber;
    } 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
        txtOldNr = GetComponent<Text>();
	} 

    void DisplayOldNumber()
    {
        txtOldNr.text = gameManagerMaster.oldNumber.ToString();
    }
}
