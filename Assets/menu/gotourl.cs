using UnityEngine;
using System.Collections;

public class gotourl : MonoBehaviour {

    public string URL;

    void OpenURL()
    {
        if(URL == "") {
            Application.OpenURL("https://www.google.com.tw");
        } else {
            Application.OpenURL(URL);
        }
    }
}
