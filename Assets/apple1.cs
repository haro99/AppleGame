using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class apple1 : MonoBehaviour {

    //スコア
    public GameObject Manager;


    // Use this for initialization
    void Start () {
        Manager = GameObject.Find("GameManager");
    }
	
	// Update is called once per frame
	void Update () {

		if (!GetComponent<Renderer>().isVisible) {
			Destroy(this.gameObject);
		}
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("普通のリンゴ");
        Manager.GetComponent<GameManager>().ScoreAdd(10);
        Destroy(this.gameObject);
    }
}
