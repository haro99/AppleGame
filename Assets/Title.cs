using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;

public class Title : MonoBehaviour {

    public GameObject Load;
    public Animator titleanimator;
    private void Start()
    {
        Task task = Task.Run(() => {
            Thread.Sleep(5000);
            In();
            Debug.Log("タスク終了");
        });

    }

    // Update is called once per frame
    void Update () {

        //スペースキーを押したかまたはスマホ画面でタッチされたらゲームシーンへ行く

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space!");
            SceneManager.LoadScene("gamemain");
            Load.SetActive(true);
        }
        //else if (Input.touchCount > 0)
        //{
        //    SceneManager.LoadScene("gamegmain");
        //}
	}
    private void In()
    {
        titleanimator.SetTrigger("In");

    }
}
