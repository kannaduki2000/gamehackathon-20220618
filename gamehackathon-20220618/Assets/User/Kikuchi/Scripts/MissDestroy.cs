using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissDestroy : MonoBehaviour
{
    private GameObject scoreManager;
    ScoreController scoreController;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreController = scoreManager.GetComponent<ScoreController>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(collision.gameObject, scoreController.MissDestroyTime);
    }


}
