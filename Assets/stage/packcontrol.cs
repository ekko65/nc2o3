using UnityEngine;
using System.Collections;

public class packcontrol : MonoBehaviour {
    public GameObject pack;
    public int wichWeapon;
    void Awake(){
        // pack.

    }
    void OnMouseUp () {
        pack.SetActive(true);
        // Debug.Log("MouseDown");
    }
}
