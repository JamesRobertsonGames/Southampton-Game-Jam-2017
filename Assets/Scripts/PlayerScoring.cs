using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoring : MonoBehaviour {

    private int Score;

    [Range(0, 100)]
    public int scoreIncrement = 1;

    [Range(0, 100)]
    public int scoreMultiplier = 1;

    // For now I am going to suggest this is not placed into the game
    bool death;



	// Use this for initialization
	void Start () {
		


	}

    public void incrementScore()
    {
        Score += scoreIncrement * scoreMultiplier;
        print(Score);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
