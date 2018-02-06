using UnityEngine;
using System.Collections;

public class lockblock : MonoBehaviour {
    public GameObject charaterSoul;
    public GameObject cometrueObject;
    public bool real;
    public Transform transform;
    public float overx;
    public float overy;
    public float x;
    public float y;
    void Awake() {
        transform = charaterSoul.GetComponent<Transform>();
        cometrueObject.SetActive(false);
        real = true;
    }
    void Update() {
        x = transform.position.x;
        y = transform.position.y;
        if(transform.position.y > overy && real) {
            real = false;
            cometrueObject.SetActive(true);
        }

    }

}
