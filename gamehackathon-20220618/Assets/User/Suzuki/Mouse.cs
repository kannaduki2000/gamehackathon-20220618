using System.Collections;
using UnityEngine;

public class Mouse : MonoBehaviour

{
    //オブジェクトをクリックしてドラッグ状態にある間呼び出される関数（Unityのマウスイベント）
    void OnMouseDrag()
    {
        //マウスカーソル及びオブジェクトのスクリーン座標を取得
        Vector3 objectScreenPoint =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        //スクリーン座標をワールド座標に変換
        Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

        //オブジェクトの座標を変更する
        transform.position = objectWorldPoint;
        //https://qiita.com/ToneUs/items/0f45e1a427102d9e8a27
        //https://qiita.com/moriba/items/bd485d2a2938b28484a9
    }
}