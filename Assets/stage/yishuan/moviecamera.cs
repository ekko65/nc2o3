using UnityEngine;
using System.Collections;

public class moviecamera : MonoBehaviour {
    public GameObject charaterSoul;
    // public bool real;
    public Transform transform;

    void Awake() {
        transform = charaterSoul.GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update () {
        if(transform.position.y > 3.2 && transform.position.y < 10) {
            GetComponent<Animator>().SetInteger("whichblock", 2);
        } else if (transform.position.y > 10  && transform.position.y < 16.8) {
            GetComponent<Animator>().SetInteger("whichblock", 3);
        } else if (transform.position.y > 16.8) {
            GetComponent<Animator>().SetInteger("whichblock", 4);
        }
    }
}
