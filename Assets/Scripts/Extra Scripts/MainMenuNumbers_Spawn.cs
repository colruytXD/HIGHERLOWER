using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuNumbers_Spawn : MonoBehaviour {

    [SerializeField]
    int resX = 1920;   //This is mobile {P9}
    [SerializeField]
    int resY = 1080;
    [SerializeField]
    public int maxHeight;

    [Space(10)]

    [SerializeField]
    int maxNumber = 99;
    [SerializeField]
    int minNumber = 0;

    [Space(10)]

    [SerializeField]
    GameObject txtParent;
    [SerializeField]
    GameObject txtPrefab;
    [SerializeField]
    int maxTxts;

    public List<GameObject> txts = new List<GameObject>();
    int currentDisplayed = 0;

	void OnEnable() 
	{
		SetInitialReferences();
        Spawn();
    }

	void OnDisable() 
	{
		
	}

	void SetInitialReferences() 
	{
	}

    public Vector3 GenerateRandomPos()
    {
        Vector3 randomPos = new Vector2(Random.Range(0, resY), Random.Range(resX, maxHeight));

        return randomPos;
    }

    void Spawn()
    {
        for (int i = 0; i < maxTxts; i++)
        {
            GameObject txt;
            txt = txtPrefab;

            GameObject.Instantiate(txtPrefab, GenerateRandomPos(), Quaternion.identity, txtParent.transform);
            txt.GetComponent<Text>().text = Random.Range(minNumber, maxNumber).ToString();
            txts.Add(txt);
        }
    }
}
