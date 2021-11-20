using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public enum GameMode
{
    Ready,
    Play,
    Result,
    End
}
public class GameManager : MonoBehaviour
{
    public GameObject ResultUI, ScoreTitle, Score, TtileBack;
    public Apple apple;
    public Animator StartSignal;
    public Text ScoreUI, TimeUI;
    public int score;
    public float gametime;

    public GameMode mode;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gametime = 30f;
        StartCoroutine("Starting");
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case GameMode.Play:
                gametime -= Time.deltaTime;
                if (gametime < 0)
                {
                    apple.enabled = false;
                    mode = GameMode.Result;
                }
                break;
            case GameMode.Result:
                Result();
                mode = GameMode.End;
                break;
        }
        ScoreUI.text = score.ToString();
        int inttime = (int)gametime;
        TimeUI.text = inttime.ToString();
    }
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(2);
        StartSignal.SetTrigger("In");
        yield return new WaitForSeconds(4);
        apple.enabled = true;
        mode = GameMode.Play;
    }

    private void Result()
    {
        Score.GetComponent<Text>().text = score.ToString();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(ResultUI.transform.DOLocalMoveY(0, 2f));
        sequence.Append(ScoreTitle.transform.DOScale(1, 1f));
        sequence.Append(Score.transform.DOScale(1, 1f)).OnComplete(()=>
        {
            this.TtileBack.SetActive(true);
        });
    }
    public void ScoreAdd(int point)
    {
        score += point;
    }
}
