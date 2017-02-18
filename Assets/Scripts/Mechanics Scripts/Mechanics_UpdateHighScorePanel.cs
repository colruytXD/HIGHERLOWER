using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;
public class Mechanics_UpdateHighScorePanel : MonoBehaviour {

    GameManager_Master gameManagerMaster;

    [SerializeField]
    Text txtHighScore;

    void OnEnable() 
	{ 
		SetInitialReferences();
        UpdateHighscore();
        gameManagerMaster.EventRightAnswer += UpdateHighscore;
	} 
	
	void OnDisable() 
	{
        gameManagerMaster.EventRightAnswer -= UpdateHighscore;
    } 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
        txtHighScore = GetComponent<Text>();
	}

    void UpdateHighscore()
    {
        if (gameManagerMaster.currentScore > gameManagerMaster.HighScore)
        {
            gameManagerMaster.HighScore = gameManagerMaster.currentScore;
            PlayerPrefs.SetInt("Highscore", gameManagerMaster.HighScore);
            txtHighScore.text = "Highscore: " + gameManagerMaster.HighScore.ToString();
        }
        else
        {
            txtHighScore.text = "Highscore: " + gameManagerMaster.HighScore.ToString();
        }
    }
}
