using UnityEngine;
using System.Collections;

public class stageleave : MonoBehaviour {
    public GameObject charaterSoul;
    public Transform charaterTransform;
    public float selfx;
    public float selfy;
    public bool doOrNot;
    private gotoaryu leavecode;
    void Awake(){
        doOrNot = true;
        charaterTransform = charaterSoul.GetComponent<Transform>();
        leavecode = GetComponent<gotoaryu>();
        selfx = GetComponent<Transform>().position.x;
        selfy = GetComponent<Transform>().position.y;
    }
    // Update is called once per frame
    void Update () {
        if(doOrNot == true){
            if (charaterTransform.position.x < (selfx + 0.15) && charaterTransform.position.x > (selfx - 0.15)) {
                if (charaterTransform.position.y < (selfy + 1) && charaterTransform.position.y > (selfy - 1)) {
                    leavecode.enabled = !leavecode.enabled;
                    doOrNot = false;
                }
            }
        }

    }
}
