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
        text.text = score.ToString() + "point";
    }

    public void ScoreAdd(int point)
    {
        score += point;
    }

    public int Scorethrow() {

        return score;
    }
}
