using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInst : MonoBehaviour
{
    [SerializeField] private GameObject inst1;
    [SerializeField] private GameObject inst2;
    [SerializeField] private GameObject inst3;
    [SerializeField] private GameObject inst4;

    private bool process = false;

    private int rnd = 0;
    [SerializeField] private float m_RecastTime=0.0f;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 50; i++)
        {
            StartCoroutine(InstObj());
        }
        
    }
    IEnumerator InstObj()
    {
        if (!process)
        {
            process = true;
            rnd = Random.Range(0, 4);
            Debug.Log(rnd);
            switch (rnd)
            {
                case 0:
                    Instantiate(inst1);
                    break;
                case 1:
                    Instantiate(inst2);
                    break;
                case 2:
                    Instantiate(inst3);
                    break;
                case 3:
                    Instantiate(inst4);
                    break;

                default:
                    Debug.Log("Error");
                    break;
            }


                    yield return new WaitForSeconds(m_RecastTime);
            //
            process = false;

        }
    }
}
