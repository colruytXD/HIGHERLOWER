using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class GameManager_TogglePausePanel : MonoBehaviour {

    [SerializeField]
    GameObject pnlPaused, pnlGame;

    GameManager_Master gameManagerMaster;

	void OnEnable() 
	{ 
		SetInitialReferences();
        gameManagerMaster.EventPauseGame += TogglePausePanel;
	} 
	
	void OnDisable() 
	{
        gameManagerMaster.EventPauseGame -= TogglePausePanel;
    } 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	} 

    void TogglePausePanel()
    {
        pnlGame.SetActive(!gameManagerMaster.isPaused);
        pnlPaused.SetActive(gameManagerMaster.isPaused);
    }
}
