using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuNumbers_Animate : MonoBehaviour {

    Vector2 beginPos;
    Vector2 endPos;

    bool move = false;

    [SerializeField, Range(0, 1000)]
    float speed = 100; 

	void OnEnable() 
	{
		SetInitialReferences();
        Invoke("Movement", 0.1f);
	}

	void OnDisable() 
	{
		
	}

	void SetInitialReferences() 
	{
		
	}

    void Update()
    {
        if(move)
        {
            gameObject.transform.position = transform.position - new Vector3(0, 5) * Time.deltaTime * speed;
        }

        if(transform.position.y < -10)
        {
            gameObject.transform.position = transform.parent.GetComponent<MainMenuNumbers_Spawn>().GenerateRandomPos();
        }
    }

    void Movement()
    {
        move = true;
    }
}
