using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
            //����Script�����Ă���gameObject��
            //��Scene�ɐ؂�ւ��Ă������Ȃ�
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���N���b�N�������ꂽ��TestMainScene�����[�h����
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TestMainScene");
        }

        //�N���A����Score��ʂ��o�āA���N���b�N������TestTitle�����[�h����
        
    }
}
