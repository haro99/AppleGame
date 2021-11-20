using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pctitle : MonoBehaviour {


    // Update is called once per frame
    void Update () {

        //スペースキーを押したかまたはスマホ画面でタッチされたらゲームシーンへ行く

        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Space!");
            SceneManager.LoadScene("PCgamemain");
        }
	}
}
