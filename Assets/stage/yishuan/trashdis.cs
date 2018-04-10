using UnityEngine;
using System.Collections;

public class trashdis : MonoBehaviour
{

    public GameObject charaterSoul;
    public GameObject cometrueObject;
    public Transform charaterTransform;
    public float overx;
    public float overy;
    public float x;
    public float y;
    public bool once;
    void Awake()
    {
        charaterTransform = charaterSoul.GetComponent<Transform>();
        cometrueObject.SetActive(true);
        once = true;
    }
    void Update()
    {
        x = charaterTransform.position.x;
        y = charaterTransform.position.y;
        if (charaterTransform.position.y < (overy + 2) && charaterTransform.position.y > (overy - 2))
        {
            if (charaterTransform.position.x < overx)
            {
                cometrueObject.SetActive(false);
            }
            else
            {
                cometrueObject.SetActive(true);
            }
        }
    }
}
