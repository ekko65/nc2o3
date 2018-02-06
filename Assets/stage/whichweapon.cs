using UnityEngine;
using System.Collections;

public class whichweapon : MonoBehaviour {
    public int weaponNumber;
    void Awake() {
        weaponNumber = -1;
    }
    public void changeWeapon(int insertNumber) {
        weaponNumber  = insertNumber;
    }
}
