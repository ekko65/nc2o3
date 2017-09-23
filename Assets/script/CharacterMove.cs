using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {
    public GameObject TouchCamera;
    public TouchWhere TouchWhere;
    public string left_right;
    public bool bHold;
    void Awake() {
        TouchWhere = TouchCamera.GetComponent<TouchWhere>();
    }
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        bHold = TouchWhere.bHold;
        Debug.Log(bHold);
        if (bHold == true){
            Debug.Log(123);
            left_right = TouchWhere.left_right;
            Debug.Log(left_right);
        }

    }
}
