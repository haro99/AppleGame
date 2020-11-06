using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {

    public Text text;
    public bool gametime;
	// Use this for initialization
	void Start () {
        gametime = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (gametime)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-0.1f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0.1f, 0f, 0f);
            }
        }
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("OnTriggerEnter2D: " + other.gameObject.name);
        text.GetComponent<Score>().ScoreAdd();
        Destroy(other.gameObject);
	}
    public void timeout() {
        gametime = false;
    }
}
