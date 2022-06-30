using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [HideInInspector] public int Score = 0;
    public int PlusScore = 100;
    public Text ScoreText;
    public float DestroyTime = 0.5f;//仕分ける箱に接触した物体を消去するまでの時間
    public float MissDestroyTime = 0.0f;//MissZoneに接触したオブジェクトを消去するまでの時間

    private void Update()
    {
        ScoreText.text = string.Format("Score:{0}", Score);
    }

}
