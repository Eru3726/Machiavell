using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpriset : MonoBehaviour
{
    private Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    public int jumpcout;

    KeyCode jumpcode;

    // Start is called before the first frame update
    void Start()
    {
        jumpcode = GameData.jumpkey;

        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpcode) && jumpcout < 2)
        {
            jumpcout++; //��Ԃ��тɃJ�E���g��1���₷
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grand"))
        {
            Debug.Log("banana");
            jumpcout = 0;�@//�n�ʂɐG�ꂽ��l��0�ɖ߂�
        }
    }

}
