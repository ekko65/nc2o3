using UnityEngine;
using System.Collections;

public class moviecamera : MonoBehaviour
{
    public GameObject charaterSoul;
    // public bool real;
    public Transform charaterTransform;

    void Awake()
    {
        charaterTransform = charaterSoul.GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (charaterTransform.position.y > 3.2 && charaterTransform.position.y < 10)
        {
            GetComponent<Animator>().SetInteger("whichblock", 2);
        }
        else if (charaterTransform.position.y > 10 && charaterTransform.position.y < 16.8)
        {
            GetComponent<Animator>().SetInteger("whichblock", 3);
        }
        else if (charaterTransform.position.y > 16.8)
        {
            GetComponent<Animator>().SetInteger("whichblock", 4);
        }
    }
}
