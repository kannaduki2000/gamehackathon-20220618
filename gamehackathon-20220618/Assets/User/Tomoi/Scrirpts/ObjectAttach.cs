using UnityEngine;
using UnityEngine.Serialization;

public class ObjectAttach : MonoBehaviour
{
    [FormerlySerializedAs("MoveSpeed")] [SerializeField]
    private float moveSpeed = 1f;
    [FormerlySerializedAs("DestroyDisplayPosition")] [SerializeField]
    private float destroyDisplayPosition = 0f;

    /// <summary>
    /// マウスでつかんでいる状態
    /// つかんでいる状態がtrue
    /// </summary>
    private bool isHold = false; 

    void Update()
    {
        Vector3 newPosition = transform.position;
        if (!isHold)
        {
            newPosition.y += -moveSpeed * Time.deltaTime ;
            transform.position = newPosition;
        }
        
        //オブジェクトがdestroyDisplayPositionより下に移動したら削除
        if (transform.position.y < destroyDisplayPosition)
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
