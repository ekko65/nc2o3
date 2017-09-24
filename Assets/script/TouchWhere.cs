using UnityEngine;
using System.Collections;
/**
 * 空間函式定義
 */
public class gDefine
{
    public enum Direction
    {
        over,
        Left,
        Right
    }
}
/**
 * 主程式
 * TouchWhere 判斷按住哪個位置
 *
 */
public class TouchWhere : MonoBehaviour {
    // private Vector2 m_screenPos = new Vector2();
    public string left_right;
    public bool bHold = false;
    /**
     * 不停偵測
     */
    void Update() {
        #if UNITY_EDITOR || UNITY_STANDALONE
            MouseInput();   // 滑鼠偵測
        #elif UNITY_ANDROID
            MobileInput();  // 觸碰偵測
        #endif
    }
    /**
     * 手機輸入
     */
    // void MobileInput() {
    //     if (Input.touchCount <= 0) {
    //         left_right = ("nothing");
    //         doit = false;
    //         return;
    //     }
    //     //1個手指觸碰螢幕
    //         //開始觸碰
    //     if (Input.touches[0].phase == TouchPhase.Began) {
    //         Debug.Log("Began");
    //     //紀錄觸碰位置
    //         if (720 >( Input.touches[0].position.x) && (Input.touches[0].position.x) > 0) {
    //             if (305> (Input.touches[0].position.y) && (Input.touches[0].position.y) > 160) {
    //                 m_screenPos = Input.touches[0].position;
    //             }
    //         }
    //         m_screenPos = Input.touches[0].position;
    //         //手指移動
    //     }
    //     //手指離開螢幕
    //     if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled) {
    //         Debug.Log("Ended");
    //         Vector2 pos = Input.touches[0].position;
    //         gDefine.Direction mDirection = HandDirection(m_screenPos, pos);
    //         Debug.Log("mDirection: " + mDirection.ToString());
    //     }
    //         //攝影機縮放，如果1個手指以上觸碰螢幕
    // }
    /**
     * 滑鼠按下去的
     */
    void MouseInput() {
        if (Input.GetMouseButton(0)) {
            bHold = true;
            // Debug.Log(Input.mousePosition);
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            HandDirection(pos);
        } else {
            bHold = false;
        }
    }

    gDefine.Direction HandDirection(Vector2 _vTouchPos){
        /**
         * 判斷壓住的點是左邊還是右邊
         * @param  {Vector} _vTouchPos.x < 250 小於250是左邊
         * @param  {Vector} _vTouchPos.x > 650 大於650是右邊
         * @return {0}
         */
        if (Mathf.Abs(_vTouchPos.x) < 250){
            left_right = ("left");
        } else if (Mathf.Abs(_vTouchPos.x) > 650){
            left_right = ("right");
        } else{
            left_right = ("middle");
        }
        return 0;
    }
    // gDefine.Direction HandDirection(Vector2 StartPos, Vector2 EndPos) {
    //     gDefine.Direction mDirection;

    //     //手指水平移動
    //     if (Mathf.Abs(StartPos.x - EndPos.x) > Mathf.Abs(StartPos.y - EndPos.y)) {
    //         if (StartPos.x > EndPos.x) {
    //             //手指向左滑動
    //             mDirection = gDefine.Direction.Left;
    //             left_right = ("left");
    //             doit = true;
    //         } else {
    //             //手指向右滑動
    //             mDirection = gDefine.Direction.Right;

    //             left_right = ("right");
    //             doit = true;
    //         }
    //     } else {
    //         mDirection = gDefine.Direction.over;
    //         left_right = ("nothing");
    //         doit = true;
    //     }
    //     return mDirection;
    // }
}