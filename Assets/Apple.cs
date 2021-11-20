using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Apple : MonoBehaviour {

    bool gametime;
	//apple生成とX座標の乱数
	System.Random rand = new System.Random ();
	//appleオブジェクト生成
    public GameObject apple1;
    //apple1オブジェクト生成
    public GameObject apple2;

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

                //10分の1の確率でゴールドのリンゴを出す
                if (0 == rand.Next(0, 10))
                {
                    //goldappleを配置
                    //Instantiate(apple2, new Vector3(rand.Next(-5, 5), 6), Quaternion.identity);
                    GameObject go = Instantiate(apple2, new Vector3(rand.Next(-5, 5), 6), Quaternion.identity) as GameObject;
                    //名前をappleに変更
                    go.name = apple2.name;
                }
                else
                {
                    //appleを幅内に配置
                    //Instantiate(apple1, new Vector3(rand.Next(-5, 5), 6), Quaternion.identity);
                    GameObject go = Instantiate(apple1, new Vector3(rand.Next(-5, 5), 6), Quaternion.identity) as GameObject;
                    //名前をappleに変更
                    go.name = apple1.name;

                }
            }
        }
	}
    public void timeout() {
        gametime = false;
    }
}
