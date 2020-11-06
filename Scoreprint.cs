using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreprint : MonoBehaviour{

    public Text scoreprint;

    public void Scoreadd(int score) {
        scoreprint.text = score.ToString();
    }
}
