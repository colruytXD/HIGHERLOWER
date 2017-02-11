using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class GameManager_ToggleGameOverScreen : MonoBehaviour {

    GameManager_Master gameManagerMaster;
    [SerializeField]
    GameObject pnlGameOver, pnlGame;

	void OnEnable() 
	{ 
		SetInitialReferences();
        gameManagerMaster.EventWrongAnwer += ToggleGameOverScreen;
	} 
	
	void OnDisable() 
	{
        gameManagerMaster.EventWrongAnwer -= ToggleGameOverScreen;
	} 
	
	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
		 
	} 

    void ToggleGameOverScreen()
    {
        pnlGameOver.SetActive(true);
        pnlGame.SetActive(false);
    }
}
