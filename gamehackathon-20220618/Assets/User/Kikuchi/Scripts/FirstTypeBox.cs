using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTypeBox : MonoBehaviour
{
    public int ResultScore = 0;
    [SerializeField]
    private int PlusScore = 100;
    int DisplayCount =0;


    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ScoreResult();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "FirstType")
        {
            ResultScore += PlusScore;
        }

    }

    public int ScoreResult()
    {
            ++DisplayCount;
            Debug.Log(ResultScore);
            return ResultScore;
    }

}


