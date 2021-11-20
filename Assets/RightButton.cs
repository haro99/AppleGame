using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour {

    //ボタンを押し続けてる時は移動するように設定する

    public Basket basket;
    //ボタンを押されているか真偽
    bool righton = false;

    public void PushDown()
    {
        //ボタンを押してる間は真
        righton = true;
    }

    public void PushUp()
    {
        //ボタンを離してる間は偽
        righton = false;
    }

    void Update()
    {
        //ボタンを押したか？
        if (righton)
        {
            Move();
        }
    }

    public void Move()
    {
        //バスケットをみぎへ移動
        basket.transform.position += new Vector3(0.1f, 0f, 0f);
    }
}
