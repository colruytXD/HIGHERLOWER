using System.Collections; 
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine; 
public class Mechanics_UpdateScorePanel : MonoBehaviour {

    GameManager_Master gameManagerMaster;
    [SerializeField]
    Text txtCurrentScore, txtHighScore;

	void OnEnable() 
	{ 
		SetInitialReferences();
        gameManagerMaster.EventRightAnswer += UpdateCurrentScore;
        gameManagerMaster.EventRightAnswer += UpdateHighscore;
        
	} 

    void Start()
    {
        UpdateHighscore();
    }
	
	void OnDisable() 
	{
        gameManagerMaster.EventRightAnswer -= UpdateCurrentScore;
        gameManagerMaster.EventRightAnswer -= UpdateHighscore;
    } 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
	} 

    void UpdateCurrentScore()
    {
        gameManagerMaster.currentScore += 1;
        txtCurrentScore.text = "Current score: " + gameManagerMaster.currentScore.ToString();
    }

    void UpdateHighscore()
    {
        if(gameManagerMaster.currentScore > gameManagerMaster.HighScore)
        {
            gameManagerMaster.HighScore = gameManagerMaster.currentScore;
            PlayerPrefs.SetInt("Highscore", gameManagerMaster.HighScore);
            txtHighScore.text = "Highscore: " +  gameManagerMaster.HighScore.ToString();
        }
        else
        {
            txtHighScore.text = "Highscore: " + gameManagerMaster.HighScore.ToString();
        }
    }
}
