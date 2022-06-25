using System;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(RectTransform))]
public class ObjectAttach : MonoBehaviour
{
    [FormerlySerializedAs("MoveSpeed")] [SerializeField]
    private float moveSpeed = 1f;
    [FormerlySerializedAs("DestroyDisplayPosition")] [SerializeField]
    private float destroyDisplayPosition = 0f;

    private RectTransform _rectTransform;
    
    /// <summary>
    /// マウスでつかんでいる状態
    /// つかんでいる状態がtrue
    /// </summary>
    private bool isHold = false;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 newPosition = _rectTransform.position;
        if (!isHold)
        {
            newPosition.y += -moveSpeed * Time.deltaTime ;
            _rectTransform.position = newPosition;
        }
        
        Debug.Log(_rectTransform.position.y);
        //オブジェクトがdestroyDisplayPositionより下に移動したら削除
        if (_rectTransform.position.y < destroyDisplayPosition)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// つかんでいる状態を更新する
    /// </summary>
    /// <param name="b"></param>
    public void SetIsHold(bool b)
    {
        isHold = b;
    }
}
