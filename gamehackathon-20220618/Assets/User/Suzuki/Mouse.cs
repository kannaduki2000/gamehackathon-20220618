using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouse : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeReference]
    private bool Flag1B = false;
    [SerializeReference]
    private bool Flag2A = false;
    [SerializeReference]
    private bool Flag1A = false;
    [SerializeReference]
    private bool Flag2B = false;
    //�@�_���i�X�R�A�j
    public int Acount = 0;
    public int Bcount = 0;

    private Vector2 prevPos; //�ۑ����Ă�������position
    private RectTransform rectTransform; // �ړ��������I�u�W�F�N�g��RectTransform
    private RectTransform parentRectTransform; // �ړ��������I�u�W�F�N�g�̐e(Panel)��RectTransform

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        parentRectTransform = rectTransform.parent as RectTransform;
    }


    // �h���b�O�J�n���̏���
    public void OnBeginDrag(PointerEventData eventData)
    {
        // �h���b�O�O�̈ʒu���L�����Ă���
        //RectTransform�̏ꍇ��position�ł͂Ȃ�anchoredPosition���g��
        prevPos = rectTransform.anchoredPosition;

    }

    // �h���b�O���̏���
    public void OnDrag(PointerEventData eventData)
    {
        // eventData.position����A�e�ɏ]��localPosition�ւ̕ϊ����s��
        // �I�u�W�F�N�g�̈ʒu��localPosition�ɕύX����

        Vector2 localPosition = GetLocalPosition(eventData.position);
        rectTransform.anchoredPosition = localPosition;
    }

    // �h���b�O�I�����̏���
    public void OnEndDrag(PointerEventData eventData)
    {
        Flag2A = true;
        Flag2B = true;
        if (Flag1A == true)
        {
            if (Flag2A == true)
            {
                Acount++;
                Flag1A = false;
                Flag2A = false;
                // Destroy(this.gameObject);
            }
        }
        if (Flag1B == true)
        {
            if (Flag2B == true)
            {
                Bcount++;
                Flag1B = false;
                Flag2B = false;
                // Destroy(this.gameObject);
            }
        }
        // �I�u�W�F�N�g���h���b�O�O�̈ʒu�ɖ߂�
        rectTransform.anchoredPosition = prevPos;
        // Destroy(this.gameObject);

    }

    // ScreenPosition����localPosition�ւ̕ϊ��֐�
    private Vector2 GetLocalPosition(Vector2 screenPosition)
    {
        Vector2 result = Vector2.zero;

        // screenPosition��e�̍��W�n(parentRectTransform)�ɑΉ�����悤�ϊ�����.
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform, screenPosition, Camera.main, out result);

        return result;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "A")
        {
            Flag1A = true;
        }
        else
        {
            Flag1A = false;
        }
        if (collision.gameObject.tag == "B")
        {
            Flag1B = true;
        }
        else
        {
            Flag1B = false;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D: " + other.gameObject.name);
    }
}