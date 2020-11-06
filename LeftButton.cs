using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

    public Basket basket;
    bool righton = false;

    public void PushDown()
    {
        righton = true;
    }

    public void PushUp()
    {
        righton = false;
    }

    void Update()
    {
        if (righton)
        {
            Move();
        }
    }

    public void Move()
    {
        basket.transform.position += new Vector3(-0.1f, 0f, 0f);
    }
}
