using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    public int hp;

    float key;    //左右移動
    int key2 = 0; //反転

    Rigidbody2D rigid2D;
 //   float walkForce = 30.0f;
 //   float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        //左矢印が押された時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            key = -1.5f;
            key2 = -1;
            transform.Translate(key, 0, 0);
        }

        //右矢印が押された時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            key = 1.5f;
            key2 = 1;
            transform.Translate(key, 0, 0);
        }


        if(key2 != 0)
        {
            transform.localScale = new Vector3(key2 * -2, 2, 1);
        }

    }

    public void LButtonDown()
    {
        key = -1.5f;
        key2 = -1;
        transform.Translate(key, 0, 0);
    }

    public void RButtonDown()
    {
        key = 1.5f;
        key2 = 1;
        transform.Translate(key, 0, 0);
    }
}
