// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Jumptoanother : MonoBehaviour {
    public Transform _charaterTransform;
    public GameObject _charaterSoul;
    public Vector2 _transPosition;
    
    void Awake() {
        _charaterTransform = _charaterSoul.GetComponent<Transform>();
    }
    // Update is called once per frame
    void OnCollisionEnter() {
        _charaterSoul.transform.position = _transPosition;
    }
}
