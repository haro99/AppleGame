using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apple2 : MonoBehaviour
{
    public GameObject Manager;

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ゴールドのリンゴだよ");
        Manager.GetComponent<GameManager>().ScoreAdd(100);
        Destroy(this.gameObject);
    }
}
