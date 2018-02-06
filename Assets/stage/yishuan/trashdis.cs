using UnityEngine;
using System.Collections;

public class trashdis : MonoBehaviour {

    public GameObject charaterSoul;
    public GameObject cometrueObject;
    public Transform transform;
    public float overx;
    public float overy;
    public float x;
    public float y;
    public bool once;
    void Awake() {
        transform = charaterSoul.GetComponent<Transform>();
        cometrueObject.SetActive(true);
        once = true;
    }
    void Update() {
        x = transform.position.x;
        y = transform.position.y;
        if(transform.position.y < (overy  + 2) && transform.position.y > (overy - 2)) {
            if(transform.position.x < overx){
                cometrueObject.SetActive(false);
            } else {
                cometrueObject.SetActive(true);
            }
        }
    }
}
