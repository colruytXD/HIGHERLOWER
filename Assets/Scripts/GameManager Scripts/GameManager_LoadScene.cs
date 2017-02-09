using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_LoadScene : MonoBehaviour {

    GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventGoToGameMenu += LoadScene;
        gameManagerMaster.EventGoToMainMenu += LoadScene;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventGoToGameMenu -= LoadScene;
        gameManagerMaster.EventGoToMainMenu -= LoadScene;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void LoadScene(int sceneNr)
    {
        SceneManager.LoadSceneAsync(sceneNr);
    } 
}
