using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jyanp : MonoBehaviour
{
    private Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    public int jumpcout = 0;
    public float jumpingPower;
    public GameObject graund;
    KeyCode jumpcode;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        jumpcode = GameData.jumpkey;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpcode) && jumpcout < 2)
        {
            //カウントが2未満のときのみジャンプができる
            Jump();
            jumpcout++; //飛ぶたびにカウントを1増やす
        }
    }

    void Jump()
    {
        //this.animator.SetTrigger("Jump Triger");
        //rb2d.AddForce(Vector2.up * jumpingPower); //ジャンプ力の判定
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingPower);
    }

}
