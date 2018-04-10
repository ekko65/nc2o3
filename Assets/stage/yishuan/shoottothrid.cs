using UnityEngine;
using System.Collections;

public class shoottothrid : MonoBehaviour
{
    public GameObject charaterSoul;
    public Transform charaterTransform;
    public Vector3 toGo;
    public Vector3 move;
    public float speed = 1f;//移動速度
    // Use this for initialization
    void Awake()
    {
        // toGo = Vector3(2.15, 12.53, 0);
        charaterTransform = charaterSoul.GetComponent<Transform>();
        // move = (toGo - charaterTransform.position)/50;
    }

    void Update()
    {
        //讓使用者每按一次 ↑ 時都移動一次，這只是為了方便看出每次移動的距離
        if (charaterTransform.position.y < 12.5)
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
