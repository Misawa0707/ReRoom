using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //  移動スピード
    [SerializeField]
    private Vector2 speed = Vector2.zero;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb = this.GetComponent<Rigidbody>();

        //  移動関数
        Move();

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.tag == "ladder")
        {
            Debug.Log("hit");
            Climb();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        rb.useGravity = true;
    }

    void Move()
    {
        //  プレイヤーの現在座標
        Vector2 pos = transform.position;

        //  左キーが押されたら
        if (Input.GetKey("left"))
        {
            pos.x -= speed.x;
        }
        //  右キーが押されたら
        else if (Input.GetKey("right"))
        {
            pos.x += speed.x;
        }
        ////  上キーが押されたら
        //else if (Input.GetKey("up"))
        //{
        //    pos.y += 0.5f;
        //}

        //  プレイヤーの移動
        transform.position = pos;
    }

    void Climb()
    {
        
        //  プレイヤーの現在座標
        Vector2 pos = transform.position;

        if (Input.GetKey("up"))
        {
            pos.y += 0.25f;

        }

        if (Input.GetKey("down"))
        {
            pos.y -= 0.25f;

        }

        rb.useGravity = false;

        //  プレイヤーの移動
        transform.position = pos;
    }
}
