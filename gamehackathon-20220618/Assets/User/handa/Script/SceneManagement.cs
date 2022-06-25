using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
            //このScriptがついているgameObjectは
            //別Sceneに切り替えても消えない
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックがをされたらTestMainSceneをロードする
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TestMainScene");
        }

        //クリアしてScore画面が出て、左クリックしたらTestTitleをロードする
        
    }
}
