using UnityEngine;
using System.Collections;

public class shoottothrid : MonoBehaviour {
    public GameObject charaterSoul;
    public Transform transform;
    public Vector3 toGo;
    public Vector3 move;
    public float speed = 1f;//移動速度
    // Use this for initialization
    void Awake() {
        // toGo = Vector3(2.15, 12.53, 0);
        transform = charaterSoul.GetComponent<Transform>();
        // move = (toGo - transform.position)/50;
    }

    void Update()
    {
        //讓使用者每按一次 ↑ 時都移動一次，這只是為了方便看出每次移動的距離
        if (transform.position.y <12.5)
        {
            transform.position = toGo;
            // transform.position = Vector3.Lerp(transform.position, Vector3(2.15, 12.53, 0), speed);
            // speed = calculateNewSpeed();
        } else {
            return;
        }
    }

}
