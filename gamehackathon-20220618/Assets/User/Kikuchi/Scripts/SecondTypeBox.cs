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

        if (collision.tag == "") //���������̂̃^�O��ݒ肵�Ă�������
        {
            scoreController.Score += scoreController.PlusScore;
            Destroy(collision.gameObject, scoreController.DestroyTime);//�ڐG�����Q�[���I�u�W�F�N�g��DestroyTime���o�ߌ�ɏ���
        }

        else//���������̈ȊO�Ȃ�X�R�A�����Z�����ɏ���
        {
            Destroy(collision.gameObject, scoreController.DestroyTime);
        }

    }

}


