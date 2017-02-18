using System.Collections; 
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine; 
public class Mechanics_UpdateScorePanel : MonoBehaviour {

    GameManager_Master gameManagerMaster;

    [SerializeField]
    Text txtCurrentScore;

	void OnEnable() 
	{ 
		SetInitialReferences();
        gameManagerMaster.EventRightAnswer += UpdateCurrentScore;
        
        txtCurrentScore = GetComponent<Text>();
	} 

    void Start()
    {
        UpdateCurrentScorePanel();
    }


    void OnDisable() 
	{
        gameManagerMaster.EventRightAnswer -= UpdateCurrentScore;
    } 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
	} 

    void UpdateCurrentScore()
    {
        gameManagerMaster.currentScore += 1;
        UpdateCurrentScorePanel();
    }    

    void UpdateCurrentScorePanel()
    {
        txtCurrentScore.text = "Current score: " + gameManagerMaster.currentScore.ToString();
    }
}
