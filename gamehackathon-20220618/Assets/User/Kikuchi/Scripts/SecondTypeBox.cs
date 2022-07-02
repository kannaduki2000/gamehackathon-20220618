using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTypeBox : MonoBehaviour
{

    private GameObject scoreManager;
    ScoreController scoreController;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreController = scoreManager.GetComponent<ScoreController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "") //正しいもののタグを設定してください
        {
            scoreController.Score += scoreController.PlusScore;
            Destroy(collision.gameObject, scoreController.DestroyTime);//接触したゲームオブジェクトをDestroyTimeが経過後に消去
        }

        else//正しいもの以外ならスコアを加算せずに消去
        {
            Destroy(collision.gameObject, scoreController.DestroyTime);
        }

    }

}


