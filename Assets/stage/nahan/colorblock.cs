using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorblock : MonoBehaviour
{
    // 鍵盤方格，物件陣列
    public GameObject[] colorBlock;
    // 鍵盤方格，position
    public Vector2[] blockPosition;
    //腳色
    public GameObject charater;
    public GameObject target;   //目標方塊    
    public float speed = 1 / 10;    //速度    
    public int rotationAngle = 0;
    private float distanceToTarget;   //往目標的距離    
    private bool move;
    public bool jumpAction = false;

    public Vector3 circleHeart;
    public float circler;
    public float speedToMovex;
    // Use charater for initialization
    void Start()
    {
    }
    void fetchTheBox()
    {
        // 抓取物件的座標
        int countNumber = 0;
        foreach (var gameObjectName in colorBlock)
        {
            if (gameObjectName == null)
            {
                continue;
            }
            blockPosition[countNumber] = gameObjectName.GetComponent<Transform>().position;
            countNumber++;
        }

    }
    //方程式常數
    private float numberC;
    private float numberA;
    //微調修正向量
    public Vector3 addVector;
    private Vector3 changeTarget;
    //一次只能有一個方塊致能
    private int iBoxCounter = 0;
    public BoxCollider[] oColorCollider;
    void Update()
    {
        // 移動的函式
        if (jumpAction)
        {
            //判斷Y軸，決定角色向佐還是像右
            if (((charater.transform.position.x) - (changeTarget.x)) > 0)
            {
                speedToMovex = speedToMovex * -1;
            }
            else
            {
                speedToMovex = speedToMovex * 1;
            }

            //判斷Y軸，決定角色向上還是向下
            // if (((changeTarget.y) - (charater.transform.position.y)) > 0)
            // {
            //     speedToMovex = speedToMovex * 1;
            // }
            // else
            // {
            //     speedToMovex = speedToMovex * -1;
            // }
            //計算兩者的距離
            changeTarget = target.transform.position + addVector;
            numberA = ((changeTarget.y) - (charater.transform.position.y)) / ((changeTarget.x) - (charater.transform.position.x));
            numberC = changeTarget.y - numberA * changeTarget.x;
            move = true;
            targetBoxcollider = target.GetComponent<BoxCollider>();
            StartCoroutine(Move());
            jumpAction = false;
        }
    }
    private BoxCollider targetBoxcollider;
    IEnumerator Move()
    {
        while (move)  //移动到目标点停止移动  
        {
            targetBoxcollider.enabled = false;
            float currentDist = Vector3.Distance(charater.transform.position, changeTarget);
            if (currentDist < 0.18f)
            {
                //停止移動
                move = false;
                targetBoxcollider.enabled = true;
                //判斷是往下一個目標還是上一個

                // BoxCollider preBoxCollider;
                // if (iBoxCounter - 1 >= 0)
                // {
                //     preBoxCollider = colorBlock[iBoxCounter - 1].GetComponent<BoxCollider>();
                //     preBoxCollider.enabled = false;
                // }
                // colorBlock[iBoxCounter] = target;
                // iBoxCounter++;
                speedToMovex = Mathf.Abs(speedToMovex);
                fetchTheBox();
            }
            charater.transform.position = new Vector3(charater.transform.position.x + speedToMovex, (numberA * (charater.transform.position.x + speedToMovex) + numberC), charater.transform.position.z);
            yield return null;
        }
    }
}
