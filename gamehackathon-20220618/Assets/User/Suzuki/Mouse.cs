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
    //　点数（スコア）
    public int Acount = 0;
    public int Bcount = 0;

    private Vector2 prevPos; //保存しておく初期position
    private RectTransform rectTransform; // 移動したいオブジェクトのRectTransform
    private RectTransform parentRectTransform; // 移動したいオブジェクトの親(Panel)のRectTransform

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        parentRectTransform = rectTransform.parent as RectTransform;
    }


    // ドラッグ開始時の処理
    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        //RectTransformの場合はpositionではなくanchoredPositionを使う
        prevPos = rectTransform.anchoredPosition;

    }

    // ドラッグ中の処理
    public void OnDrag(PointerEventData eventData)
    {
        // eventData.positionから、親に従うlocalPositionへの変換を行う
        // オブジェクトの位置をlocalPositionに変更する

        Vector2 localPosition = GetLocalPosition(eventData.position);
        rectTransform.anchoredPosition = localPosition;
    }

    // ドラッグ終了時の処理
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
        // オブジェクトをドラッグ前の位置に戻す
        rectTransform.anchoredPosition = prevPos;
        // Destroy(this.gameObject);

    }

    // ScreenPositionからlocalPositionへの変換関数
    private Vector2 GetLocalPosition(Vector2 screenPosition)
    {
        Vector2 result = Vector2.zero;

        // screenPositionを親の座標系(parentRectTransform)に対応するよう変換する.
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