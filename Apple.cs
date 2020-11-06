using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Apple : MonoBehaviour {

    bool gametime;
	//apple生成とX座標の乱数
	System.Random rand = new System.Random ();
	//appleオブジェクト生成
    public GameObject obj;

	// Use this for initialization
	void Start () {
        //Instantiate(obj, new Vector3(0, 0), Quaternion.identity);
        //Instantiate(obj, new Vector3(0, 2), Quaternion.identity);
        gametime = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (gametime)
        {
            if (0 == rand.Next(0, 30))
            {
                //appleを幅内に配置
                Instantiate(obj, new Vector3(rand.Next(-5, 5), 6), Quaternion.identity);
            }
        }
	}
    public void timeout() {
        gametime = false;
    }
}
