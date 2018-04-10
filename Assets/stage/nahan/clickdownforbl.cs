using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickdownforbl : MonoBehaviour
{
    //指向管理colorBlock得物件，此物件必須要colorblock.cs的程式
    public GameObject controlBox;
    private GameObject theTarget;

    public GameObject self;
    // Use this for initialization
    void Start()
    {
        // theTarget = controlBox.GetComponent<colorblock>().target;

    }
    void OnMouseUp()
    {
        controlBox.GetComponent<colorblock>().target = self;
        controlBox.GetComponent<colorblock>().jumpAction = true;
    }
}
