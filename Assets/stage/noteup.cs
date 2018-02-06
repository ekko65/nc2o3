using UnityEngine;
using System.Collections;

public class noteup : MonoBehaviour {
    public GameObject charaterSoul;
    // public bool real;
    public Transform charaterTransform;
    public GameObject atBlock;
    public Animator changeAnimate;
    public GameObject Canvas;
    public whichweapon whichweapon;
    public int weaponNumber;
    public int completeNumber;
    public float jumpx;
    public float jumpy;
    public bool triggerit;
    public string changeword;
    private bool doOrNot;
    void Awake() {
        charaterTransform = charaterSoul.GetComponent<Transform>();
        changeAnimate = atBlock.GetComponent<Animator>();
        whichweapon = Canvas.GetComponent<whichweapon>();
        doOrNot = true;
        triggerit = false;
    }
    // Update is called once per frame
    void Update () {
        if (charaterTransform.position.x < (jumpx + 0.2) && charaterTransform.position.x > (jumpx - 0.6)) {
            if (charaterTransform.position.y < (jumpy + 1) && charaterTransform.position.y > (jumpy - 1)) {
                GetComponent<Animator>().SetBool("jumpout", true);
                if(triggerit == true){
                    changeAnimate.SetBool(changeword, true);
                }
                doOrNot = false;
            }
        } else if (!doOrNot) {
            GetComponent<Animator>().SetBool("jumpout", false);
        }
    }
    void OnMouseDown() {
        weaponNumber = whichweapon.weaponNumber;
        if(weaponNumber == completeNumber) {
            triggerit = true;
        }
        if (completeNumber == 999) {
            triggerit = true;
        }
    }
}
