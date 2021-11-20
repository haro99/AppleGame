using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

    //ボタンを押し続けてる時は移動するように設定する

    public Basket basket;
    //ボタンを押されているか真偽
    bool righton = false;

    public void PushDown()
    {
        //ボタンを押し続けてる間は真
        righton = true;
    }

    public void PushUp()
    {
        //ボタンを離してる間はは偽
        righton = false;
    }

    void Update()
    {
        //ボタンが押されてるか？
        if (righton)
        {
            Move();
        }
    }

    public void Move()
    {
        //バスケットを左へ移動
        basket.transform.position += new Vector3(-0.1f, 0f, 0f);
    }
}
