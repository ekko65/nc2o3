using UnityEngine;
using System.Collections;

public class quitgame : MonoBehaviour {
public bool quitIt;
void Awake (){
    quitIt = false;
}
void Start(){
    Application.Quit();

}


}
