using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ボタンが押された場合　今回呼び出される関数
public class testTitleScene: MonoBehaviour
{
    protected static int Score = 0;

    void Start()
    {
    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        SceneManager.LoadScene("test");//呼び出したいシーン
        Debug.Log("押された!");  // ログを出力
    }

    public static int GetScore()
    {
        return Score ;
    }
}
