using UnityEngine;
using System.Collections;

public class chairmove : MonoBehaviour
{
    public GameObject charaterSoul;
    public Transform charaterTransform;
    public Vector3 toGo;
    public Vector3 triggerPoint;
    public Vector3 move;
    public float speed = 1f;//移動速度

    void Awake()
    {
        // toGo = Vector3(2.15, 12.53, 0);
        charaterTransform = charaterSoul.GetComponent<Transform>();
        // move = (toGo - charaterTransform.position)/50;
    }

    void OnMouseDown()
    {
        if (charaterTransform.position.y > -4.2)
        {
            charaterTransform.position = toGo;
            // charaterTransform.position = Vector3.Lerp(charaterTransform.position, Vector3(2.15, 12.53, 0), speed);
            // speed = calculateNewSpeed();
        }
        else
        {
            return;
        }
    }
}
