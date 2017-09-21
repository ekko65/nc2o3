using UnityEngine;
using System.Collections;

public class maincamera : MonoBehaviour
{
    public GameObject character;
    public Vector2 charpos;
    public bool abc = false;
    void update()
       {
            if (abc)
            {
            charpos = character.transform.position;
            charpos.x--;
        }
        }
    void OnMouseDown()
    {
        abc = true;
    }



}
    

    



