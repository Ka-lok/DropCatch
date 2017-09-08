using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBalls : MonoBehaviour {

    public GameObject Ball;

    float timeBetweenSpawns = 2f;
    float timer;

    int difficultyCounter = 0;



	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
      
        if (difficultyCounter < 5)
        {
            timeBetweenSpawns = 1f;
        }
        if (difficultyCounter < 10 && difficultyCounter > 5)
        {
            timeBetweenSpawns = 0.5f;
        }

        if (timer > timeBetweenSpawns)
        {
            Instantiate(Ball, new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(0,5), 0), Quaternion.identity);
            timer = 0;
            if (difficultyCounter < 10) {
                difficultyCounter = difficultyCounter + 1;
            }
        }


   


    }
}
