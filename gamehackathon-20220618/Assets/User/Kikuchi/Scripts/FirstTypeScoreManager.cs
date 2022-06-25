using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTypeScoreManager : MonoBehaviour
{
    public int ResultScore = 0;
    [SerializeField]
    private int PlusScore = 100;
    int SortedNumber = 0;
    bool GameFinish = false;
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
            SortedNumber++;
        }

        else if (collision.tag == "SecondType")
        {
            ResultScore -= PlusScore;
            SortedNumber++;
        }
        Debug.Log(SortedNumber);

        if(SortedNumber ==10)
        {
            GameFinish = true;
        }

    }

    public int ScoreResult()
    {
        if (GameFinish == true && DisplayCount == 0)
        {
            ++DisplayCount;
            Debug.Log(ResultScore);
            return ResultScore;
        }
            
        else
        {
            return 0;
        }
    }

}


