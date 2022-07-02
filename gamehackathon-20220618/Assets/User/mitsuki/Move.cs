using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float m_Speed = 1.0f;
    public bool picked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!picked)
        {
            this.transform.position -= transform.up*m_Speed*Time.deltaTime;
        }

        if (this.gameObject.transform.position.y <= -6)//�����Y���W�ɂ�����폜�Q���c�Q
        {
            Destroy(this.gameObject);
        }
    }
}
