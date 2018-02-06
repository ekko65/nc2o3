using UnityEngine;
using System.Collections;

public class chairmove : MonoBehaviour {
    public GameObject charaterSoul;
    public Transform transform;
    public Vector3 toGo;
    public Vector3 triggerPoint;
    public Vector3 move;
    public float speed = 1f;//移動速度

    void Awake() {
        // toGo = Vector3(2.15, 12.53, 0);
        transform = charaterSoul.GetComponent<Transform>();
        // move = (toGo - transform.position)/50;
    }

    void OnMouseDown() {
        if (transform.position.y > -4.2)
        {
            transform.position = toGo;
            // transform.position = Vector3.Lerp(transform.position, Vector3(2.15, 12.53, 0), speed);
            // speed = calculateNewSpeed();
        } else {
            return;
        }
    }
}
