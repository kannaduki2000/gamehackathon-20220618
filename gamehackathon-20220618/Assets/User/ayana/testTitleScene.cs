using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�{�^���������ꂽ�ꍇ�@����Ăяo�����֐�
public class testTitleScene: MonoBehaviour
{
    protected static int Score = 0;

    void Start()
    {
    }

    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        SceneManager.LoadScene("test");//�Ăяo�������V�[��
        Debug.Log("�����ꂽ!");  // ���O���o��
    }

    public static int GetScore()
    {
        return Score ;
    }
}
