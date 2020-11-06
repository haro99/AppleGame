using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text text;
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }

    public void ScoreAdd()
    {
        score += 10;
    }

    public int Scorethrow() {

        return score;
    }
}
