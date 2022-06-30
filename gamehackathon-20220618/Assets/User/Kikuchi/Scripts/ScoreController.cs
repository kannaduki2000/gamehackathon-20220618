using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [HideInInspector] public int Score = 0;
    public int PlusScore = 100;
    public Text ScoreText;
    public float DestroyTime = 0.5f;//�d�����锠�ɐڐG�������̂���������܂ł̎���
    public float MissDestroyTime = 0.0f;//MissZone�ɐڐG�����I�u�W�F�N�g����������܂ł̎���

    private void Update()
    {
        ScoreText.text = string.Format("Score:{0}", Score);
    }

}
