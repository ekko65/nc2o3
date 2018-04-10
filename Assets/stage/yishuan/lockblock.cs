using UnityEngine;
using System.Collections;

public class lockblock : MonoBehaviour
{
    public GameObject charaterSoul;
    public GameObject cometrueObject;
    public bool real;
    public Transform charaterTransform;
    public float overx;
    public float overy;
    public float x;
    public float y;
    void Awake()
    {
        charaterTransform = charaterSoul.GetComponent<Transform>();
        cometrueObject.SetActive(false);
        real = true;
    }
    void Update()
    {
        x = charaterTransform.position.x;
        y = charaterTransform.position.y;
        if (charaterTransform.position.y > overy && real)
        {
            real = false;
            cometrueObject.SetActive(true);
        }

    }

}
