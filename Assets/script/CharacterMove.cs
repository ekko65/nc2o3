using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {
    public GameObject TouchCamera;
    public GameObject character;
    public TouchWhere TouchWhere;
    public string left_right;
    public bool bHold;
    private Animator animator;

    void Awake() {
        TouchWhere = TouchCamera.GetComponent<TouchWhere>();
        animator = character.GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        bHold = TouchWhere.bHold;
        if (bHold == true){
            left_right = TouchWhere.left_right;
            moveY(left_right);
        } else {
            // character.Animator.setInt("mode", 0);
            // animator.SetInt("mode", 0);
            animator.SetInteger("mode", 0);
        }
    }
        /**
     * 角色移動
     * @param  {[type]} _whichSide [description]
     * @return {[type]}            [description]
     */
    int moveY(string _whichSide){
        if (_whichSide == "left"){
            transform.position += Vector3.left*Time.deltaTime*2;
            animator.SetInteger("mode", 1);
        } else if (_whichSide == "right"){
            transform.position += Vector3.right*Time.deltaTime*2;
            animator.SetInteger("mode", -1);
        }
        return 0;
    }

}
